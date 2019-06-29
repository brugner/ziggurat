namespace Management.Misc
{
   partial class SplashScreenView
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenView));
         this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
         this.lbCopyright = new DevExpress.XtraEditors.LabelControl();
         this.lbLoadingMessage = new DevExpress.XtraEditors.LabelControl();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.lbVersion = new DevExpress.XtraEditors.LabelControl();
         this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // marqueeProgressBarControl1
         // 
         this.marqueeProgressBarControl1.EditValue = 0;
         this.marqueeProgressBarControl1.Location = new System.Drawing.Point(12, 231);
         this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
         this.marqueeProgressBarControl1.Size = new System.Drawing.Size(426, 12);
         this.marqueeProgressBarControl1.TabIndex = 5;
         // 
         // lbCopyright
         // 
         this.lbCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
         this.lbCopyright.Location = new System.Drawing.Point(12, 286);
         this.lbCopyright.Name = "lbCopyright";
         this.lbCopyright.Size = new System.Drawing.Size(10, 13);
         this.lbCopyright.TabIndex = 6;
         this.lbCopyright.Text = "©";
         // 
         // lbLoadingMessage
         // 
         this.lbLoadingMessage.Location = new System.Drawing.Point(12, 212);
         this.lbLoadingMessage.Name = "lbLoadingMessage";
         this.lbLoadingMessage.Size = new System.Drawing.Size(51, 13);
         this.lbLoadingMessage.TabIndex = 7;
         this.lbLoadingMessage.Text = "Iniciando..";
         // 
         // labelControl1
         // 
         this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 25F);
         this.labelControl1.Appearance.Options.UseFont = true;
         this.labelControl1.Location = new System.Drawing.Point(315, 261);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(123, 45);
         this.labelControl1.TabIndex = 10;
         this.labelControl1.Text = "Ziggurat";
         // 
         // lbVersion
         // 
         this.lbVersion.Appearance.Options.UseTextOptions = true;
         this.lbVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
         this.lbVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.lbVersion.Location = new System.Drawing.Point(273, 212);
         this.lbVersion.Name = "lbVersion";
         this.lbVersion.Size = new System.Drawing.Size(165, 13);
         this.lbVersion.TabIndex = 11;
         this.lbVersion.Text = "Versión 1.0.0.0";
         // 
         // pictureEdit2
         // 
         this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
         this.pictureEdit2.EditValue = global::Management.Properties.Resources.splash;
         this.pictureEdit2.Location = new System.Drawing.Point(12, 12);
         this.pictureEdit2.Name = "pictureEdit2";
         this.pictureEdit2.Properties.AllowFocused = false;
         this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
         this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
         this.pictureEdit2.Properties.Appearance.Options.UseImage = true;
         this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
         this.pictureEdit2.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit2.Properties.InitialImage")));
         this.pictureEdit2.Properties.ShowMenu = false;
         this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchHorizontal;
         this.pictureEdit2.Properties.ZoomAccelerationFactor = 1D;
         this.pictureEdit2.Size = new System.Drawing.Size(426, 180);
         this.pictureEdit2.TabIndex = 9;
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox1.Image = global::Management.Properties.Resources.favicon_black_128;
         this.pictureBox1.Location = new System.Drawing.Point(256, 261);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(53, 50);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 12;
         this.pictureBox1.TabStop = false;
         // 
         // SplashScreenView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(450, 320);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.lbVersion);
         this.Controls.Add(this.labelControl1);
         this.Controls.Add(this.pictureEdit2);
         this.Controls.Add(this.lbLoadingMessage);
         this.Controls.Add(this.lbCopyright);
         this.Controls.Add(this.marqueeProgressBarControl1);
         this.Name = "SplashScreenView";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.SplashScreenView_Load);
         ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
      private DevExpress.XtraEditors.LabelControl lbCopyright;
      private DevExpress.XtraEditors.LabelControl lbLoadingMessage;
      private DevExpress.XtraEditors.PictureEdit pictureEdit2;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private DevExpress.XtraEditors.LabelControl lbVersion;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
}
