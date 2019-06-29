namespace AccessControl.MemberLogin
{
   partial class MemberLoginView
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberLoginView));
         this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
         this.statusStrip = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
         this.lbCopyleft = new System.Windows.Forms.ToolStripStatusLabel();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.lbMessage = new DevExpress.XtraEditors.LabelControl();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
         this.txtDNI = new System.Windows.Forms.TextBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.statusStrip.SuspendLayout();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // defaultLookAndFeel
         // 
         this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
         // 
         // statusStrip
         // 
         this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lbCopyleft});
         this.statusStrip.Location = new System.Drawing.Point(0, 159);
         this.statusStrip.Name = "statusStrip";
         this.statusStrip.Size = new System.Drawing.Size(554, 22);
         this.statusStrip.SizingGrip = false;
         this.statusStrip.TabIndex = 4;
         // 
         // toolStripStatusLabel2
         // 
         this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
         this.toolStripStatusLabel2.Size = new System.Drawing.Size(481, 17);
         this.toolStripStatusLabel2.Spring = true;
         // 
         // lbCopyleft
         // 
         this.lbCopyleft.Name = "lbCopyleft";
         this.lbCopyleft.Size = new System.Drawing.Size(58, 17);
         this.lbCopyleft.Text = "copyright";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.lbMessage);
         this.groupBox1.Controls.Add(this.labelControl1);
         this.groupBox1.Controls.Add(this.labelControl2);
         this.groupBox1.Controls.Add(this.txtDNI);
         this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.Location = new System.Drawing.Point(146, 2);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(396, 138);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         // 
         // lbMessage
         // 
         this.lbMessage.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbMessage.Appearance.ForeColor = System.Drawing.Color.Red;
         this.lbMessage.Appearance.Options.UseFont = true;
         this.lbMessage.Appearance.Options.UseForeColor = true;
         this.lbMessage.Appearance.Options.UseTextOptions = true;
         this.lbMessage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.lbMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.lbMessage.Location = new System.Drawing.Point(15, 92);
         this.lbMessage.Name = "lbMessage";
         this.lbMessage.Size = new System.Drawing.Size(361, 19);
         this.lbMessage.TabIndex = 6;
         this.lbMessage.Text = "                     ";
         // 
         // labelControl1
         // 
         this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl1.Appearance.Options.UseFont = true;
         this.labelControl1.Appearance.Options.UseTextOptions = true;
         this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
         this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
         this.labelControl1.Location = new System.Drawing.Point(15, 119);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(170, 16);
         this.labelControl1.TabIndex = 5;
         this.labelControl1.Text = "Presiona * si necesitas ayuda";
         // 
         // labelControl2
         // 
         this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl2.Appearance.Options.UseFont = true;
         this.labelControl2.Appearance.Options.UseTextOptions = true;
         this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
         this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
         this.labelControl2.Location = new System.Drawing.Point(15, 35);
         this.labelControl2.Name = "labelControl2";
         this.labelControl2.Size = new System.Drawing.Size(361, 19);
         this.labelControl2.TabIndex = 4;
         this.labelControl2.Text = "Ingresa tu número de documento para identificarte";
         // 
         // txtDNI
         // 
         this.txtDNI.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDNI.Location = new System.Drawing.Point(15, 60);
         this.txtDNI.MaxLength = 8;
         this.txtDNI.Name = "txtDNI";
         this.txtDNI.Size = new System.Drawing.Size(361, 30);
         this.txtDNI.TabIndex = 1;
         this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::AccessControl.Properties.Resources.favicon_black_128;
         this.pictureBox1.Location = new System.Drawing.Point(12, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(128, 128);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pictureBox1.TabIndex = 6;
         this.pictureBox1.TabStop = false;
         // 
         // MemberLoginView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(554, 181);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.statusStrip);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "MemberLoginView";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Ziggurat | **";
         this.Load += new System.EventHandler(this.MemberLoginView_Load);
         this.statusStrip.ResumeLayout(false);
         this.statusStrip.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private System.Windows.Forms.StatusStrip statusStrip;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
      private System.Windows.Forms.ToolStripStatusLabel lbCopyleft;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.TextBox txtDNI;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private DevExpress.XtraEditors.LabelControl lbMessage;
   }
}