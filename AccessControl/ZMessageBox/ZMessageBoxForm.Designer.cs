namespace AccessControl.ZMessageBox
{
   partial class ZMessageBoxForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZMessageBoxForm));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.pbIcon = new System.Windows.Forms.PictureBox();
			this.lbMessage = new System.Windows.Forms.Label();
			this.lbSubject = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseTextOptions = true;
			this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labelControl1.Location = new System.Drawing.Point(0, 163);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(650, 26);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Presiona cualquier tecla para continuar..";
			// 
			// pbIcon
			// 
			this.pbIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbIcon.Image = global::AccessControl.Properties.Resources.informationMessageIcon256;
			this.pbIcon.Location = new System.Drawing.Point(22, 12);
			this.pbIcon.Name = "pbIcon";
			this.pbIcon.Size = new System.Drawing.Size(142, 145);
			this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIcon.TabIndex = 1;
			this.pbIcon.TabStop = false;
			// 
			// lbMessage
			// 
			this.lbMessage.BackColor = System.Drawing.Color.Transparent;
			this.lbMessage.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMessage.Location = new System.Drawing.Point(182, 12);
			this.lbMessage.Name = "lbMessage";
			this.lbMessage.Size = new System.Drawing.Size(456, 145);
			this.lbMessage.TabIndex = 3;
			this.lbMessage.Text = "message";
			this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbSubject
			// 
			this.lbSubject.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSubject.Appearance.Options.UseFont = true;
			this.lbSubject.Location = new System.Drawing.Point(22, 12);
			this.lbSubject.Name = "lbSubject";
			this.lbSubject.Size = new System.Drawing.Size(54, 18);
			this.lbSubject.TabIndex = 4;
			this.lbSubject.Text = "subject";
			this.lbSubject.Visible = false;
			// 
			// ZMessageBoxForm
			// 
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 189);
			this.ControlBox = false;
			this.Controls.Add(this.lbSubject);
			this.Controls.Add(this.lbMessage);
			this.Controls.Add(this.pbIcon);
			this.Controls.Add(this.labelControl1);
			this.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(8);
			this.Name = "ZMessageBoxForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ZMessageBoxForm";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZMessageBoxForm_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.PictureBox pbIcon;
      private System.Windows.Forms.Label lbMessage;
		private DevExpress.XtraEditors.LabelControl lbSubject;
	}
}