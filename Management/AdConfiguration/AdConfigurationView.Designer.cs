namespace Management.AdConfiguration
{
   partial class AdConfigurationView
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
			this.components = new System.ComponentModel.Container();
			DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdConfigurationView));
			DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
			DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
			this.btnOK = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.txtText = new System.Windows.Forms.RichTextBox();
			this.cmsText = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmsFont = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsColor = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.cmsCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.fontDialog = new System.Windows.Forms.FontDialog();
			this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
			this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
			this.pbImage1 = new System.Windows.Forms.PictureBox();
			this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
			this.pbImage2 = new System.Windows.Forms.PictureBox();
			this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
			this.pbImage3 = new System.Windows.Forms.PictureBox();
			this.linkRedimImage = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.linkRemoveImage = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.dtpStart = new System.Windows.Forms.DateTimePicker();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.dtpEnd = new System.Windows.Forms.DateTimePicker();
			this.ofdProfilePicture = new System.Windows.Forms.OpenFileDialog();
			this.cmsText.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
			this.xtraTabControl.SuspendLayout();
			this.xtraTabPage1.SuspendLayout();
			this.xtraTabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage1)).BeginInit();
			this.xtraTabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage2)).BeginInit();
			this.xtraTabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage3)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(243, 452);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "Aceptar";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.CausesValidation = false;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(324, 452);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancelar";
			// 
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
			// 
			// txtText
			// 
			this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtText.ContextMenuStrip = this.cmsText;
			this.txtText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtText.Location = new System.Drawing.Point(3, 3);
			this.txtText.MaxLength = 100;
			this.txtText.Name = "txtText";
			this.txtText.Size = new System.Drawing.Size(378, 287);
			this.txtText.TabIndex = 6;
			this.txtText.Text = "";
			// 
			// cmsText
			// 
			this.cmsText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsFont,
            this.cmsColor,
            this.cmsSeparator,
            this.cmsCopy,
            this.cmsPaste});
			this.cmsText.Name = "cmsText";
			this.cmsText.Size = new System.Drawing.Size(111, 98);
			// 
			// cmsFont
			// 
			this.cmsFont.Name = "cmsFont";
			this.cmsFont.Size = new System.Drawing.Size(110, 22);
			this.cmsFont.Text = "Fuente";
			this.cmsFont.Click += new System.EventHandler(this.cmsFont_Click);
			// 
			// cmsColor
			// 
			this.cmsColor.Name = "cmsColor";
			this.cmsColor.Size = new System.Drawing.Size(110, 22);
			this.cmsColor.Text = "Color";
			this.cmsColor.Click += new System.EventHandler(this.cmsColor_Click);
			// 
			// cmsSeparator
			// 
			this.cmsSeparator.Name = "cmsSeparator";
			this.cmsSeparator.Size = new System.Drawing.Size(107, 6);
			// 
			// cmsCopy
			// 
			this.cmsCopy.Name = "cmsCopy";
			this.cmsCopy.Size = new System.Drawing.Size(110, 22);
			this.cmsCopy.Text = "Copiar";
			this.cmsCopy.Click += new System.EventHandler(this.cmsCopy_Click);
			// 
			// cmsPaste
			// 
			this.cmsPaste.Name = "cmsPaste";
			this.cmsPaste.Size = new System.Drawing.Size(110, 22);
			this.cmsPaste.Text = "Pegar";
			this.cmsPaste.Click += new System.EventHandler(this.cmsPaste_Click);
			// 
			// xtraTabControl
			// 
			this.xtraTabControl.Location = new System.Drawing.Point(12, 12);
			this.xtraTabControl.Name = "xtraTabControl";
			this.xtraTabControl.SelectedTabPage = this.xtraTabPage1;
			this.xtraTabControl.Size = new System.Drawing.Size(386, 318);
			this.xtraTabControl.TabIndex = 8;
			this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
			this.xtraTabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl_SelectedPageChanged);
			// 
			// xtraTabPage1
			// 
			this.xtraTabPage1.Controls.Add(this.txtText);
			this.xtraTabPage1.Name = "xtraTabPage1";
			this.xtraTabPage1.Size = new System.Drawing.Size(384, 293);
			this.xtraTabPage1.Text = "Texto";
			// 
			// xtraTabPage2
			// 
			this.xtraTabPage2.Controls.Add(this.pbImage1);
			this.xtraTabPage2.Name = "xtraTabPage2";
			this.xtraTabPage2.Size = new System.Drawing.Size(384, 293);
			this.xtraTabPage2.Text = "Imagen #1";
			// 
			// pbImage1
			// 
			this.pbImage1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbImage1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbImage1.Location = new System.Drawing.Point(0, 0);
			this.pbImage1.Name = "pbImage1";
			this.pbImage1.Size = new System.Drawing.Size(384, 293);
			this.pbImage1.TabIndex = 0;
			this.pbImage1.TabStop = false;
			this.pbImage1.Click += new System.EventHandler(this.pbImage1_Click);
			// 
			// xtraTabPage3
			// 
			this.xtraTabPage3.Controls.Add(this.pbImage2);
			this.xtraTabPage3.Name = "xtraTabPage3";
			this.xtraTabPage3.Size = new System.Drawing.Size(384, 293);
			this.xtraTabPage3.Text = "Imagen #2";
			// 
			// pbImage2
			// 
			this.pbImage2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbImage2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbImage2.Location = new System.Drawing.Point(0, 0);
			this.pbImage2.Name = "pbImage2";
			this.pbImage2.Size = new System.Drawing.Size(384, 293);
			this.pbImage2.TabIndex = 1;
			this.pbImage2.TabStop = false;
			this.pbImage2.Click += new System.EventHandler(this.pbImage2_Click);
			// 
			// xtraTabPage4
			// 
			this.xtraTabPage4.Controls.Add(this.pbImage3);
			this.xtraTabPage4.Name = "xtraTabPage4";
			this.xtraTabPage4.Size = new System.Drawing.Size(384, 293);
			this.xtraTabPage4.Text = "Imagen #3";
			// 
			// pbImage3
			// 
			this.pbImage3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbImage3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbImage3.Location = new System.Drawing.Point(0, 0);
			this.pbImage3.Name = "pbImage3";
			this.pbImage3.Size = new System.Drawing.Size(384, 293);
			this.pbImage3.TabIndex = 1;
			this.pbImage3.TabStop = false;
			this.pbImage3.Click += new System.EventHandler(this.pbImage3_Click);
			// 
			// linkRedimImage
			// 
			this.linkRedimImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkRedimImage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkRedimImage.Location = new System.Drawing.Point(207, 336);
			this.linkRedimImage.Name = "linkRedimImage";
			this.linkRedimImage.Size = new System.Drawing.Size(20, 13);
			toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			toolTipTitleItem1.Appearance.Options.UseImage = true;
			toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
			toolTipTitleItem1.Text = "Redimensionar";
			toolTipItem1.LeftIndent = 6;
			toolTipItem1.Text = "Redimensiona la imagen de la publicidad.";
			superToolTip1.Items.Add(toolTipTitleItem1);
			superToolTip1.Items.Add(toolTipItem1);
			this.linkRedimImage.SuperTip = superToolTip1;
			this.linkRedimImage.TabIndex = 37;
			this.linkRedimImage.Text = "[ * ]";
			this.linkRedimImage.ToolTip = "Redimensionar imagen";
			this.linkRedimImage.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
			this.linkRedimImage.Visible = false;
			this.linkRedimImage.Click += new System.EventHandler(this.linkRedimImage_Click);
			// 
			// linkRemoveImage
			// 
			this.linkRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkRemoveImage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkRemoveImage.Location = new System.Drawing.Point(181, 336);
			this.linkRemoveImage.Name = "linkRemoveImage";
			this.linkRemoveImage.Size = new System.Drawing.Size(20, 13);
			toolTipTitleItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
			toolTipTitleItem2.Appearance.Options.UseImage = true;
			toolTipTitleItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem2.Image")));
			toolTipTitleItem2.Text = "Quitar";
			toolTipItem2.LeftIndent = 6;
			toolTipItem2.Text = "Quita la imagen de la publicidad.";
			superToolTip2.Items.Add(toolTipTitleItem2);
			superToolTip2.Items.Add(toolTipItem2);
			this.linkRemoveImage.SuperTip = superToolTip2;
			this.linkRemoveImage.TabIndex = 36;
			this.linkRemoveImage.Text = "[ X ]";
			this.linkRemoveImage.Visible = false;
			this.linkRemoveImage.Click += new System.EventHandler(this.linkRemoveImage_Click);
			// 
			// dtpStart
			// 
			this.dtpStart.Location = new System.Drawing.Point(46, 20);
			this.dtpStart.Name = "dtpStart";
			this.dtpStart.Size = new System.Drawing.Size(334, 21);
			this.dtpStart.TabIndex = 38;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(6, 26);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(34, 13);
			this.labelControl1.TabIndex = 39;
			this.labelControl1.Text = "Desde:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelControl2);
			this.groupBox1.Controls.Add(this.dtpEnd);
			this.groupBox1.Controls.Add(this.labelControl1);
			this.groupBox1.Controls.Add(this.dtpStart);
			this.groupBox1.Location = new System.Drawing.Point(13, 367);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(386, 79);
			this.groupBox1.TabIndex = 40;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Vigencia";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(6, 53);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(32, 13);
			this.labelControl2.TabIndex = 41;
			this.labelControl2.Text = "Hasta:";
			// 
			// dtpEnd
			// 
			this.dtpEnd.Location = new System.Drawing.Point(46, 47);
			this.dtpEnd.Name = "dtpEnd";
			this.dtpEnd.Size = new System.Drawing.Size(334, 21);
			this.dtpEnd.TabIndex = 40;
			// 
			// ofdProfilePicture
			// 
			this.ofdProfilePicture.Filter = "Imágenes (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg";
			this.ofdProfilePicture.Title = "Seleccionar imagen de perfil";
			// 
			// AdConfigurationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(411, 487);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.linkRedimImage);
			this.Controls.Add(this.linkRemoveImage);
			this.Controls.Add(this.xtraTabControl);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AdConfigurationView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Anuncio";
			this.Load += new System.EventHandler(this.CheckinView_Load);
			this.cmsText.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
			this.xtraTabControl.ResumeLayout(false);
			this.xtraTabPage1.ResumeLayout(false);
			this.xtraTabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbImage1)).EndInit();
			this.xtraTabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbImage2)).EndInit();
			this.xtraTabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbImage3)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraEditors.SimpleButton btnOK;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private System.Windows.Forms.RichTextBox txtText;
      private System.Windows.Forms.ContextMenuStrip cmsText;
      private System.Windows.Forms.ToolStripMenuItem cmsFont;
      private System.Windows.Forms.ToolStripMenuItem cmsColor;
      private System.Windows.Forms.ToolStripSeparator cmsSeparator;
      private System.Windows.Forms.ToolStripMenuItem cmsCopy;
      private System.Windows.Forms.ToolStripMenuItem cmsPaste;
      private System.Windows.Forms.ColorDialog colorDialog;
      private System.Windows.Forms.FontDialog fontDialog;
      private DevExpress.XtraTab.XtraTabControl xtraTabControl;
      private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
      private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
      private System.Windows.Forms.PictureBox pbImage1;
      private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
      private System.Windows.Forms.PictureBox pbImage2;
      private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
      private System.Windows.Forms.PictureBox pbImage3;
      private DevExpress.XtraEditors.HyperlinkLabelControl linkRedimImage;
      private DevExpress.XtraEditors.HyperlinkLabelControl linkRemoveImage;
      private System.Windows.Forms.DateTimePicker dtpStart;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.GroupBox groupBox1;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private System.Windows.Forms.DateTimePicker dtpEnd;
      private System.Windows.Forms.OpenFileDialog ofdProfilePicture;
   }
}