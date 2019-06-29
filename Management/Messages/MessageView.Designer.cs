namespace Management.Messages
{
   partial class MessageView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageView));
			DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
			DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
			DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtBody = new System.Windows.Forms.TextBox();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnSend = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.lbDateTime = new DevExpress.XtraEditors.LabelControl();
			this.lbcRecipients = new DevExpress.XtraEditors.ListBoxControl();
			this.linkAddRecipient = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.linkAddAllRecipients = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.linkRemoveAllRecipients = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			((System.ComponentModel.ISupportInitialize)(this.lbcRecipients)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(12, 221);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(40, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Mensaje";
			// 
			// txtBody
			// 
			this.txtBody.Location = new System.Drawing.Point(12, 240);
			this.txtBody.MaxLength = 200;
			this.txtBody.Multiline = true;
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new System.Drawing.Size(600, 190);
			this.txtBody.TabIndex = 5;
			this.txtBody.Validating += new System.ComponentModel.CancelEventHandler(this.txtBody_Validating);
			// 
			// btnCancel
			// 
			this.btnCancel.CausesValidation = false;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(537, 436);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancelar";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(456, 436);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 6;
			this.btnSend.Text = "Enviar";
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(12, 65);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(63, 13);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Destinatarios";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(12, 15);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(34, 13);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "Asunto";
			// 
			// txtSubject
			// 
			this.txtSubject.Location = new System.Drawing.Point(12, 34);
			this.txtSubject.MaxLength = 50;
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(600, 21);
			this.txtSubject.TabIndex = 1;
			this.txtSubject.Validating += new System.ComponentModel.CancelEventHandler(this.txtSubject_Validating);
			// 
			// lbDateTime
			// 
			this.lbDateTime.Location = new System.Drawing.Point(525, 15);
			this.lbDateTime.Name = "lbDateTime";
			this.lbDateTime.Size = new System.Drawing.Size(87, 13);
			this.lbDateTime.TabIndex = 7;
			this.lbDateTime.Text = "13/02/2018 21:51";
			// 
			// lbcRecipients
			// 
			this.lbcRecipients.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbcRecipients.Location = new System.Drawing.Point(12, 84);
			this.lbcRecipients.MultiColumn = true;
			this.lbcRecipients.Name = "lbcRecipients";
			this.lbcRecipients.Size = new System.Drawing.Size(600, 131);
			this.lbcRecipients.TabIndex = 8;
			this.lbcRecipients.TabStop = false;
			this.lbcRecipients.DoubleClick += new System.EventHandler(this.lbcRecipients_DoubleClick);
			this.lbcRecipients.Validating += new System.ComponentModel.CancelEventHandler(this.lbcRecipients_Validating);
			// 
			// linkAddRecipient
			// 
			this.linkAddRecipient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkAddRecipient.Location = new System.Drawing.Point(81, 65);
			this.linkAddRecipient.Name = "linkAddRecipient";
			this.linkAddRecipient.Size = new System.Drawing.Size(39, 13);
			toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			toolTipTitleItem1.Appearance.Options.UseImage = true;
			toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
			toolTipTitleItem1.Text = "Agregar";
			toolTipItem1.LeftIndent = 6;
			toolTipItem1.Text = "Agrega un destinatario.";
			superToolTip1.Items.Add(toolTipTitleItem1);
			superToolTip1.Items.Add(toolTipItem1);
			this.linkAddRecipient.SuperTip = superToolTip1;
			this.linkAddRecipient.TabIndex = 2;
			this.linkAddRecipient.Text = "Agregar";
			this.linkAddRecipient.Click += new System.EventHandler(this.linkAddRecipient_Click);
			// 
			// linkAddAllRecipients
			// 
			this.linkAddAllRecipients.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkAddAllRecipients.Location = new System.Drawing.Point(477, 65);
			this.linkAddAllRecipients.Name = "linkAddAllRecipients";
			this.linkAddAllRecipients.Size = new System.Drawing.Size(69, 13);
			toolTipTitleItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
			toolTipTitleItem2.Appearance.Options.UseImage = true;
			toolTipTitleItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem2.Image")));
			toolTipTitleItem2.Text = "Agregar todos";
			toolTipItem2.LeftIndent = 6;
			toolTipItem2.Text = "Agrega todos los miembros como destinatarios.";
			superToolTip2.Items.Add(toolTipTitleItem2);
			superToolTip2.Items.Add(toolTipItem2);
			this.linkAddAllRecipients.SuperTip = superToolTip2;
			this.linkAddAllRecipients.TabIndex = 3;
			this.linkAddAllRecipients.Text = "Agregar todos";
			this.linkAddAllRecipients.Click += new System.EventHandler(this.linkAddAllRecipients_Click);
			// 
			// linkRemoveAllRecipients
			// 
			this.linkRemoveAllRecipients.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkRemoveAllRecipients.Location = new System.Drawing.Point(552, 65);
			this.linkRemoveAllRecipients.Name = "linkRemoveAllRecipients";
			this.linkRemoveAllRecipients.Size = new System.Drawing.Size(60, 13);
			toolTipTitleItem3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
			toolTipTitleItem3.Appearance.Options.UseImage = true;
			toolTipTitleItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem3.Image")));
			toolTipTitleItem3.Text = "Quitar todos";
			toolTipItem3.LeftIndent = 6;
			toolTipItem3.Text = "Vacía la lista de destinatarios.";
			superToolTip3.Items.Add(toolTipTitleItem3);
			superToolTip3.Items.Add(toolTipItem3);
			this.linkRemoveAllRecipients.SuperTip = superToolTip3;
			this.linkRemoveAllRecipients.TabIndex = 4;
			this.linkRemoveAllRecipients.Text = "Quitar todos";
			this.linkRemoveAllRecipients.Click += new System.EventHandler(this.linkRemoveAllRecipients_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
			// 
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
			// 
			// MessageView
			// 
			this.AcceptButton = this.btnSend;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(632, 472);
			this.Controls.Add(this.linkRemoveAllRecipients);
			this.Controls.Add(this.linkAddAllRecipients);
			this.Controls.Add(this.linkAddRecipient);
			this.Controls.Add(this.lbcRecipients);
			this.Controls.Add(this.lbDateTime);
			this.Controls.Add(this.txtSubject);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtBody);
			this.Controls.Add(this.labelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MessageView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MessageView";
			this.Load += new System.EventHandler(this.MessageView_Load);
			((System.ComponentModel.ISupportInitialize)(this.lbcRecipients)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.TextBox txtBody;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private DevExpress.XtraEditors.SimpleButton btnSend;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private System.Windows.Forms.TextBox txtSubject;
      private DevExpress.XtraEditors.LabelControl lbDateTime;
      private DevExpress.XtraEditors.ListBoxControl lbcRecipients;
      private DevExpress.XtraEditors.HyperlinkLabelControl linkAddRecipient;
      private DevExpress.XtraEditors.HyperlinkLabelControl linkAddAllRecipients;
      private DevExpress.XtraEditors.HyperlinkLabelControl linkRemoveAllRecipients;
      private System.Windows.Forms.ErrorProvider errorProvider;
      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
   }
}