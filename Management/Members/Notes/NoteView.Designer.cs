namespace Management.Members.Notes
{
   partial class NoteView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteView));
			this.txtNoteText = new System.Windows.Forms.TextBox();
			this.lbDateTime = new DevExpress.XtraEditors.LabelControl();
			this.btnOK = new DevExpress.XtraEditors.SimpleButton();
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNoteText
			// 
			this.txtNoteText.Location = new System.Drawing.Point(12, 12);
			this.txtNoteText.MaxLength = 140;
			this.txtNoteText.Multiline = true;
			this.txtNoteText.Name = "txtNoteText";
			this.txtNoteText.Size = new System.Drawing.Size(399, 128);
			this.txtNoteText.TabIndex = 0;
			this.txtNoteText.Validating += new System.ComponentModel.CancelEventHandler(this.txtNoteText_Validating);
			// 
			// lbDateTime
			// 
			this.lbDateTime.Location = new System.Drawing.Point(12, 146);
			this.lbDateTime.Name = "lbDateTime";
			this.lbDateTime.Size = new System.Drawing.Size(63, 13);
			this.lbDateTime.TabIndex = 1;
			this.lbDateTime.Text = "labelControl1";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(255, 146);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "Aceptar";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(336, 146);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancelar";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
			// 
			// NoteView
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(431, 181);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lbDateTime);
			this.Controls.Add(this.txtNoteText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NoteView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "NoteView";
			this.Load += new System.EventHandler(this.NoteView_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtNoteText;
      private DevExpress.XtraEditors.LabelControl lbDateTime;
      private DevExpress.XtraEditors.SimpleButton btnOK;
      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private System.Windows.Forms.ErrorProvider errorProvider;
   }
}