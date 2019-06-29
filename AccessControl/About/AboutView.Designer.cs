namespace AccessControl.About
{
   partial class AboutView
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutView));
         this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
         this.lbCopyright = new DevExpress.XtraEditors.LabelControl();
         this.lbVersion = new DevExpress.XtraEditors.LabelControl();
         this.label4 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // labelControl15
         // 
         this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl15.Appearance.Options.UseFont = true;
         this.labelControl15.Location = new System.Drawing.Point(154, 164);
         this.labelControl15.Name = "labelControl15";
         this.labelControl15.Size = new System.Drawing.Size(170, 16);
         this.labelControl15.TabIndex = 16;
         this.labelControl15.Text = "Gracias por usar mi software!";
         // 
         // labelControl12
         // 
         this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl12.Appearance.Options.UseFont = true;
         this.labelControl12.Location = new System.Drawing.Point(154, 120);
         this.labelControl12.Name = "labelControl12";
         this.labelControl12.Size = new System.Drawing.Size(173, 16);
         this.labelControl12.TabIndex = 14;
         this.labelControl12.Text = "Copyleft - All wrongs reserved";
         // 
         // labelControl11
         // 
         this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl11.Appearance.Options.UseFont = true;
         this.labelControl11.Location = new System.Drawing.Point(154, 142);
         this.labelControl11.Name = "labelControl11";
         this.labelControl11.Size = new System.Drawing.Size(334, 16);
         this.labelControl11.TabIndex = 13;
         this.labelControl11.Text = "Desarrollado con ♥ desde Villa María, Córdoba - Argentina";
         // 
         // lbCopyright
         // 
         this.lbCopyright.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbCopyright.Appearance.Options.UseFont = true;
         this.lbCopyright.Location = new System.Drawing.Point(154, 98);
         this.lbCopyright.Name = "lbCopyright";
         this.lbCopyright.Size = new System.Drawing.Size(52, 16);
         this.lbCopyright.TabIndex = 12;
         this.lbCopyright.Text = "copyright";
         // 
         // lbVersion
         // 
         this.lbVersion.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbVersion.Appearance.Options.UseFont = true;
         this.lbVersion.Location = new System.Drawing.Point(154, 76);
         this.lbVersion.Name = "lbVersion";
         this.lbVersion.Size = new System.Drawing.Size(41, 16);
         this.lbVersion.TabIndex = 11;
         this.lbVersion.Text = "version";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(12, 9);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(136, 39);
         this.label4.TabIndex = 10;
         this.label4.Text = "Ziggurat";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::AccessControl.Properties.Resources.favicon_black_128;
         this.pictureBox1.Location = new System.Drawing.Point(19, 61);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(128, 128);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pictureBox1.TabIndex = 15;
         this.pictureBox1.TabStop = false;
         // 
         // AboutView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(503, 202);
         this.Controls.Add(this.labelControl15);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.labelControl12);
         this.Controls.Add(this.labelControl11);
         this.Controls.Add(this.lbCopyright);
         this.Controls.Add(this.lbVersion);
         this.Controls.Add(this.label4);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "AboutView";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Acerca de Ziggurat";
         this.Load += new System.EventHandler(this.AboutView_Load);
         this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AboutView_KeyPress);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraEditors.LabelControl labelControl15;
      private System.Windows.Forms.PictureBox pictureBox1;
      private DevExpress.XtraEditors.LabelControl labelControl12;
      private DevExpress.XtraEditors.LabelControl labelControl11;
      private DevExpress.XtraEditors.LabelControl lbCopyright;
      private DevExpress.XtraEditors.LabelControl lbVersion;
      private System.Windows.Forms.Label label4;
   }
}