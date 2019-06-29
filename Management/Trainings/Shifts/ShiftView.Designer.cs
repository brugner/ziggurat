namespace Management.Trainings.Shifts
{
   partial class ShiftView
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftView));
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.txtNumber = new System.Windows.Forms.TextBox();
         this.clbDays = new DevExpress.XtraEditors.CheckedListBoxControl();
         this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
         this.btnOK = new DevExpress.XtraEditors.SimpleButton();
         this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
         this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
         this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
         this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
         this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
         this.numQuota = new System.Windows.Forms.NumericUpDown();
         this.checkQuota = new System.Windows.Forms.CheckBox();
         this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
         this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
         ((System.ComponentModel.ISupportInitialize)(this.clbDays)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numQuota)).BeginInit();
         this.SuspendLayout();
         // 
         // labelControl1
         // 
         this.labelControl1.Location = new System.Drawing.Point(12, 15);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(41, 13);
         this.labelControl1.TabIndex = 0;
         this.labelControl1.Text = "Número:";
         // 
         // txtNumber
         // 
         this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtNumber.Location = new System.Drawing.Point(59, 15);
         this.txtNumber.Name = "txtNumber";
         this.txtNumber.ReadOnly = true;
         this.txtNumber.Size = new System.Drawing.Size(100, 14);
         this.txtNumber.TabIndex = 1;
         this.txtNumber.TabStop = false;
         // 
         // clbDays
         // 
         this.clbDays.CheckOnClick = true;
         this.clbDays.Cursor = System.Windows.Forms.Cursors.Default;
         this.clbDays.Location = new System.Drawing.Point(12, 60);
         this.clbDays.Name = "clbDays";
         this.clbDays.Size = new System.Drawing.Size(251, 131);
         this.clbDays.TabIndex = 1;
         this.clbDays.Validating += new System.ComponentModel.CancelEventHandler(this.clbDays_Validating);
         // 
         // labelControl2
         // 
         this.labelControl2.Location = new System.Drawing.Point(12, 41);
         this.labelControl2.Name = "labelControl2";
         this.labelControl2.Size = new System.Drawing.Size(20, 13);
         this.labelControl2.TabIndex = 3;
         this.labelControl2.Text = "Días";
         // 
         // labelControl3
         // 
         this.labelControl3.Location = new System.Drawing.Point(12, 211);
         this.labelControl3.Name = "labelControl3";
         this.labelControl3.Size = new System.Drawing.Size(53, 13);
         this.labelControl3.TabIndex = 4;
         this.labelControl3.Text = "Hora inicio:";
         // 
         // btnOK
         // 
         this.btnOK.Location = new System.Drawing.Point(107, 294);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(75, 23);
         this.btnOK.TabIndex = 6;
         this.btnOK.Text = "Aceptar";
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.CausesValidation = false;
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(188, 294);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 7;
         this.btnCancel.Text = "Cancelar";
         // 
         // defaultLookAndFeel
         // 
         this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
         // 
         // errorProvider
         // 
         this.errorProvider.ContainerControl = this;
         this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
         // 
         // dtpStartTime
         // 
         this.dtpStartTime.CustomFormat = "HH:mm";
         this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.dtpStartTime.Location = new System.Drawing.Point(71, 205);
         this.dtpStartTime.Name = "dtpStartTime";
         this.dtpStartTime.ShowUpDown = true;
         this.dtpStartTime.Size = new System.Drawing.Size(61, 21);
         this.dtpStartTime.TabIndex = 2;
         // 
         // labelControl4
         // 
         this.labelControl4.Location = new System.Drawing.Point(12, 260);
         this.labelControl4.Name = "labelControl4";
         this.labelControl4.Size = new System.Drawing.Size(29, 13);
         this.labelControl4.TabIndex = 5;
         this.labelControl4.Text = "Cupo:";
         // 
         // numQuota
         // 
         this.numQuota.Location = new System.Drawing.Point(71, 258);
         this.numQuota.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
         this.numQuota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.numQuota.Name = "numQuota";
         this.numQuota.Size = new System.Drawing.Size(111, 21);
         this.numQuota.TabIndex = 4;
         this.numQuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.numQuota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         // 
         // checkQuota
         // 
         this.checkQuota.AutoSize = true;
         this.checkQuota.Location = new System.Drawing.Point(189, 259);
         this.checkQuota.Name = "checkQuota";
         this.checkQuota.Size = new System.Drawing.Size(74, 17);
         this.checkQuota.TabIndex = 5;
         this.checkQuota.Text = "Cupo libre";
         this.checkQuota.UseVisualStyleBackColor = true;
         this.checkQuota.CheckedChanged += new System.EventHandler(this.checkQuota_CheckedChanged);
         // 
         // dtpEndTime
         // 
         this.dtpEndTime.CustomFormat = "HH:mm";
         this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.dtpEndTime.Location = new System.Drawing.Point(71, 232);
         this.dtpEndTime.Name = "dtpEndTime";
         this.dtpEndTime.ShowUpDown = true;
         this.dtpEndTime.Size = new System.Drawing.Size(61, 21);
         this.dtpEndTime.TabIndex = 3;
         // 
         // labelControl5
         // 
         this.labelControl5.Location = new System.Drawing.Point(12, 238);
         this.labelControl5.Name = "labelControl5";
         this.labelControl5.Size = new System.Drawing.Size(42, 13);
         this.labelControl5.TabIndex = 8;
         this.labelControl5.Text = "Hora fin:";
         // 
         // ShiftView
         // 
         this.AcceptButton = this.btnOK;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(284, 330);
         this.Controls.Add(this.dtpEndTime);
         this.Controls.Add(this.labelControl5);
         this.Controls.Add(this.checkQuota);
         this.Controls.Add(this.numQuota);
         this.Controls.Add(this.labelControl4);
         this.Controls.Add(this.dtpStartTime);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.labelControl3);
         this.Controls.Add(this.labelControl2);
         this.Controls.Add(this.clbDays);
         this.Controls.Add(this.txtNumber);
         this.Controls.Add(this.labelControl1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "ShiftView";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "ShiftView";
         this.Load += new System.EventHandler(this.ShiftView_Load);
         ((System.ComponentModel.ISupportInitialize)(this.clbDays)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numQuota)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.TextBox txtNumber;
      private DevExpress.XtraEditors.CheckedListBoxControl clbDays;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private DevExpress.XtraEditors.SimpleButton btnOK;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private System.Windows.Forms.ErrorProvider errorProvider;
      private System.Windows.Forms.DateTimePicker dtpStartTime;
      private System.Windows.Forms.CheckBox checkQuota;
      private System.Windows.Forms.NumericUpDown numQuota;
      private DevExpress.XtraEditors.LabelControl labelControl4;
      private System.Windows.Forms.DateTimePicker dtpEndTime;
      private DevExpress.XtraEditors.LabelControl labelControl5;
   }
}