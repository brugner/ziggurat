using Corlib.Config;
using Corlib.Services;
using Management.Misc;
using NLog;
using System;
using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Management
{
   class DatabaseInstaller
   {
      private static Logger _logger = LogManager.GetCurrentClassLogger();
      private static string _compressedSetupPath = string.Empty;
      private static string _extractedSetupPath = string.Empty;
      private static string _setupPath = string.Empty;
      private static ProcessView _processView = new ProcessView();

      internal static int Start()
      {
         try
         {
            if (!AppConfig.Environment.IsProduction)
               return 0;

            var firstRun = Convert.ToBoolean(ConfigurationManager.AppSettings["FirstRun"]);

            if (!firstRun)
            {
               _logger.Info("FirstRun = False: No need to install the database");
               return 0;
            }

            _logger.Info("FirstRun = True: It's necesary to install the database");
            MessageBox.Show("Se ha detectado que es la primera vez que ejecuta la aplicación, por lo tanto se procederá con la instalación de la base de datos. Esta operación es de vital importancia para el funcionamiento de la aplicación y puede tardar varios minutos.\n\nPor favor, sea tan amable de aguardar pacientemente hasta que el proceso finalice.", "Ziggurat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            ReportAttemptToInstall();
            SetPaths();
            SetExtractionDirectory();
            ExtractFiles();
            InstallEngine();
            UpdateAppSettings();
            MigrateDatabase();
            ConfigDatabase();
            DeleteExtractedFiles();
            GrantPermissionsForBackup();
            HideConfigFiles();

            MessageBox.Show("La base de datos se ha instalado correctamente. Gracias por la paciencia, ya puede disfrutar de la aplicación.", "Ziggurat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
         }
         catch (Exception ex)
         {
            ServiceLocator.SentryService.ReportError(ex);
            MessageBox.Show("Ha ocurrido un error inesperado al intentar instalar la base de datos. A continuación los detalles:\n\n" + ex.Message, "Ziggurat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 500;
         }
      }

      private static void ReportAttemptToInstall()
      {
         string message = $"Attempt to install database. [Machine name: {Environment.MachineName};User domain name: {Environment.UserDomainName};Username: {Environment.UserName};64bits: {Environment.Is64BitOperatingSystem}";
         string ip = "Not found";

         try
         {
            ip = new WebClient().DownloadString("http://icanhazip.com");
            ip = Regex.Replace(ip, @"[\u000A\u000B\u000C\u000D\u2028\u2029\u0085]+", string.Empty);
         }
         catch (Exception) { }

         message += $";IP: {ip}]";

         ServiceLocator.SentryService.ReportInfo(message);
      }

      private static void SetPaths()
      {
         _logger.Info("Setting up paths");

         if (Environment.Is64BitOperatingSystem)
            _compressedSetupPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "extra", "SQLEXPR_x64_ENU.exe");
         else
            _compressedSetupPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "extra", "SQLEXPR_x86_ENU.exe");

         _extractedSetupPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "extra", "SQL_Server_Express");
      }

      private static void SetExtractionDirectory()
      {
         _logger.Info("Setting up the extraction directory");

         if (Directory.Exists(_extractedSetupPath))
            DeleteExtractedFiles();
         else
            Directory.CreateDirectory(_extractedSetupPath);
      }

      private static void ExtractFiles()
      {
         try
         {
            _logger.Info("Extracting files..");

            _processView.Message = "Extrayendo archivos..";
            _processView.Show();
            Application.DoEvents();

            var extractProcess = new Process();
            extractProcess.StartInfo.Verb = "runas";
            extractProcess.StartInfo.FileName = _compressedSetupPath;
            extractProcess.StartInfo.Arguments = $"/Q /X:{_extractedSetupPath}";
            extractProcess.Start();
            extractProcess.WaitForExit();

            _processView.Hide();
            _logger.Info($"Extracting process finished with code {extractProcess.ExitCode}");
         }
         catch (Exception)
         {
            throw;
         }
      }

      private static void InstallEngine()
      {
         _logger.Info("Installing engine..");

         _setupPath = Path.Combine(_extractedSetupPath, "setup.exe");

         if (!File.Exists(_setupPath))
            throw new Exception("No hay suficientes permisos para continuar. Por favor, desinstala la aplicación y vuelve a instalarla en un directorio donde tengas permisos.");

         string args = @"/QS /IACCEPTSQLSERVERLICENSETERMS /HIDECONSOLE /Action=Install /Features=SQL /InstanceName=SQLZ /SAPWD=Pl4y1ngTh3Su1cid3K1ng! /ADDCURRENTUSERASSQLADMIN=TRUE /SECURITYMODE=SQL /NPENABLED=0 /TCPENABLED=0 /skiprules=RebootRequiredCheck";

         //args = "/Action=Uninstall /FEATURES=SQLEngine /INSTANCENAME=SQLZ";

         var installProcess = new Process();
         installProcess.StartInfo.FileName = _setupPath;
         installProcess.StartInfo.Arguments = args;
         installProcess.Start();
         installProcess.WaitForExit();

         _logger.Info($"Installation process finished with code {installProcess.ExitCode}");
      }

      private static void UpdateAppSettings()
      {
         _logger.Info("Updating app settings..");

         _processView.Message = "Actualizando configuración..";
         _processView.Show();
         Application.DoEvents();

         var csb = new SqlConnectionStringBuilder
         {
            DataSource = Environment.MachineName + "\\SQLZ",
            InitialCatalog = "Ziggurat",
            UserID = "sa",
            Password = "Pl4y1ngTh3Su1cid3K1ng!"
         };

         // management
         var managementConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
         managementConfig.ConnectionStrings.ConnectionStrings["Ziggurat"].ConnectionString = csb.ToString();
         managementConfig.AppSettings.Settings["FirstRun"].Value = "False";

         managementConfig.Save(ConfigurationSaveMode.Modified);
         ConfigurationManager.RefreshSection("connectionStrings");
         ConfigurationManager.RefreshSection("appSettings");

         // access control
         File.Copy(managementConfig.FilePath, managementConfig.FilePath + ".temp");
         File.Delete(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ZigguratAccessControl.exe.config"));
         File.Move(managementConfig.FilePath + ".temp", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ZigguratAccessControl.exe.config"));

         _processView.Hide();
         _logger.Info("Settings updated");
      }

      private static void MigrateDatabase()
      {
         _logger.Info("Migrating database..");

         _processView.Message = "Migrando base de datos..";
         _processView.Show();
         Application.DoEvents();

         var configuration = new Corlib.Migrations.Configuration();
         configuration.TargetDatabase = new DbConnectionInfo(ConfigurationManager.ConnectionStrings["Ziggurat"].ToString(), "System.Data.SqlClient");

         var migrator = new DbMigrator(configuration);
         migrator.Update();

         _processView.Hide();
         _logger.Info("Database migrated");
      }

      private static void ConfigDatabase()
      {
         _logger.Info("Configuring database..");

         _processView.Message = "Configurando base de datos..";
         _processView.Show();
         Application.DoEvents();

         Corlib.Migrations.Configuration config = new Corlib.Migrations.Configuration();
         config.SafeSeed();

         _processView.Hide();
         _logger.Info("Database configured");
      }

      private static void DeleteExtractedFiles()
      {
         _logger.Info("Deleting extracted files..");

         _processView.Message = "Eliminando archivos extraídos..";
         _processView.Show();
         Application.DoEvents();

         var di = new DirectoryInfo(_extractedSetupPath);

         foreach (var file in di.GetFiles())
            file.Delete();

         foreach (var dir in di.GetDirectories())
            dir.Delete(true);

         _processView.Hide();
         _logger.Info("Extracted files deleted");
      }

      private static void GrantPermissionsForBackup()
      {
         _logger.Info("Granting permission to backup folder..");

         var backupDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backup");

         if (!Directory.Exists(backupDirectory))
            Directory.CreateDirectory(backupDirectory);

         var d1 = new DirectoryInfo(backupDirectory);
         var md1 = d1.GetAccessControl();

         try
         {
            md1.AddAccessRule(new FileSystemAccessRule("NETWORK", FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow));
            d1.SetAccessControl(md1);
            _logger.Info($"Permission granted to NETWORK");
         }
         catch (Exception)
         {
            _logger.Error("Error trying to grant permissions to user NETWORK");
         }

         try
         {
            md1.AddAccessRule(new FileSystemAccessRule("SERVICE", FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow));
            d1.SetAccessControl(md1);
            _logger.Info($"Permission granted to SERVICE");
         }
         catch (Exception)
         {
            _logger.Error("Error trying to grant permissions to user SERVICE");
         }

         try
         {
            md1.AddAccessRule(new FileSystemAccessRule("NETWORK SERVICE", FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow));
            d1.SetAccessControl(md1);
            _logger.Info($"Permission granted to NETWORK SERVICE");
         }
         catch (Exception)
         {
            _logger.Error("Error trying to grant permissions to user NETWORK SERVICE");
         }
      }

      private static void HideConfigFiles()
      {
         _logger.Info("Hiding config files..");

         var d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
         var files = d.GetFiles();

         foreach (var file in files.Where(x => x.Name.ToLower().Contains("devexpress") || x.Name.ToLower().Contains(".config")))
            File.SetAttributes(file.FullName, FileAttributes.Hidden);
      }
   }
}
