using AutoMapper;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Corlib.Presenters
{
   class DatabaseBackupRecordsPresenter : IDatabaseBackupRecordsPresenter
   {
      private readonly IDatabaseBackupRecordsView _view;
      private IUnitOfWork _unitOfWork;

      public DatabaseBackupRecordsPresenter(IDatabaseBackupRecordsView view)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         RefreshRecordsList();
      }

      #region IDatabaseBackupRecordsPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void WireViewEvents()
      {
         _view.Backup += OnBackup;
         _view.OpenBackupDirectory += OnOpenBackupDirectory;
      }

      private void OnBackup()
      {
         if (!_view.Confirm("¿Esta seguro que desea realizar un backup de la base de datos?"))
            return;

         ServiceLocator.RunnerService.Run(() =>
         {
            ServiceLocator.DatabaseBackupService.Backup();
            RefreshRecordsList();
            _view.Notify("El backup se ha realizado exitosamente.", MessageType.Information);
         }, "Ha ocurrido un error al intentar realizar la copia de seguridad de la base de datos.");
      }

      private void OnOpenBackupDirectory()
      {
         var backupDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backup");

         if (Directory.Exists(backupDirectory))
            Directory.CreateDirectory(backupDirectory);

         Process.Start(backupDirectory);
      }

      #region Helpers
      private void RefreshRecordsList()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var records = _unitOfWork.DatabaseBackupRecords.GetAll();
            _view.DatabaseBackupRecords = Mapper.Map<IEnumerable<DatabaseBackupRecord>, IEnumerable<DatabaseBackupRecordViewModel>>(records);
         }
      }
      #endregion
   }
}
