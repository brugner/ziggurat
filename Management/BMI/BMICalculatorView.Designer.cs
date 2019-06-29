namespace Management.BMI
{
   partial class BMICalculatorView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculatorView));
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.gbMeasures = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numWeight = new System.Windows.Forms.NumericUpDown();
			this.numHeight = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbActivity = new System.Windows.Forms.GroupBox();
			this.rbtn5 = new System.Windows.Forms.RadioButton();
			this.rbtn4 = new System.Windows.Forms.RadioButton();
			this.rbtn3 = new System.Windows.Forms.RadioButton();
			this.rbtn2 = new System.Windows.Forms.RadioButton();
			this.rbtn1 = new System.Windows.Forms.RadioButton();
			this.gbResults = new System.Windows.Forms.GroupBox();
			this.lbBMIColor = new DevExpress.XtraEditors.LabelControl();
			this.lbCalories = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.lbBMI = new DevExpress.XtraEditors.LabelControl();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.linkMoreInfo = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.gbMeasures.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.gbActivity.SuspendLayout();
			this.gbResults.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
			// 
			// gbMeasures
			// 
			this.gbMeasures.Controls.Add(this.label4);
			this.gbMeasures.Controls.Add(this.label3);
			this.gbMeasures.Controls.Add(this.label2);
			this.gbMeasures.Controls.Add(this.numWeight);
			this.gbMeasures.Controls.Add(this.numHeight);
			this.gbMeasures.Controls.Add(this.label1);
			this.gbMeasures.Location = new System.Drawing.Point(12, 82);
			this.gbMeasures.Name = "gbMeasures";
			this.gbMeasures.Size = new System.Drawing.Size(349, 82);
			this.gbMeasures.TabIndex = 1;
			this.gbMeasures.TabStop = false;
			this.gbMeasures.Text = "Medidas";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(180, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "kg";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(178, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "cm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Peso:";
			// 
			// numWeight
			// 
			this.numWeight.Location = new System.Drawing.Point(52, 48);
			this.numWeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.numWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numWeight.Name = "numWeight";
			this.numWeight.Size = new System.Drawing.Size(120, 21);
			this.numWeight.TabIndex = 2;
			this.numWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numWeight.ValueChanged += new System.EventHandler(this.numWeight_ValueChanged);
			// 
			// numHeight
			// 
			this.numHeight.Location = new System.Drawing.Point(52, 21);
			this.numHeight.Maximum = new decimal(new int[] {
            225,
            0,
            0,
            0});
			this.numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numHeight.Name = "numHeight";
			this.numHeight.Size = new System.Drawing.Size(120, 21);
			this.numHeight.TabIndex = 1;
			this.numHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numHeight.ValueChanged += new System.EventHandler(this.numHeight_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Altura:";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
			// 
			// gbActivity
			// 
			this.gbActivity.Controls.Add(this.rbtn5);
			this.gbActivity.Controls.Add(this.rbtn4);
			this.gbActivity.Controls.Add(this.rbtn3);
			this.gbActivity.Controls.Add(this.rbtn2);
			this.gbActivity.Controls.Add(this.rbtn1);
			this.gbActivity.Location = new System.Drawing.Point(12, 170);
			this.gbActivity.Name = "gbActivity";
			this.gbActivity.Size = new System.Drawing.Size(349, 154);
			this.gbActivity.TabIndex = 2;
			this.gbActivity.TabStop = false;
			this.gbActivity.Text = "Actividad";
			// 
			// rbtn5
			// 
			this.rbtn5.AutoSize = true;
			this.rbtn5.Location = new System.Drawing.Point(9, 128);
			this.rbtn5.Name = "rbtn5";
			this.rbtn5.Size = new System.Drawing.Size(197, 17);
			this.rbtn5.TabIndex = 5;
			this.rbtn5.Tag = "5";
			this.rbtn5.Text = "Altamente activo: atleta profesional";
			this.rbtn5.UseVisualStyleBackColor = true;
			this.rbtn5.CheckedChanged += new System.EventHandler(this.rbtn5_CheckedChanged);
			// 
			// rbtn4
			// 
			this.rbtn4.AutoSize = true;
			this.rbtn4.Location = new System.Drawing.Point(9, 101);
			this.rbtn4.Name = "rbtn4";
			this.rbtn4.Size = new System.Drawing.Size(269, 17);
			this.rbtn4.TabIndex = 4;
			this.rbtn4.Tag = "4";
			this.rbtn4.Text = "Muy activo: ejercicio intenso 5 a 7 días por semana";
			this.rbtn4.UseVisualStyleBackColor = true;
			this.rbtn4.CheckedChanged += new System.EventHandler(this.rbtn4_CheckedChanged);
			// 
			// rbtn3
			// 
			this.rbtn3.AutoSize = true;
			this.rbtn3.Checked = true;
			this.rbtn3.Location = new System.Drawing.Point(9, 74);
			this.rbtn3.Name = "rbtn3";
			this.rbtn3.Size = new System.Drawing.Size(340, 17);
			this.rbtn3.TabIndex = 3;
			this.rbtn3.TabStop = true;
			this.rbtn3.Tag = "3";
			this.rbtn3.Text = "Moderadamente activo: ejercicio moderado 3 a 5 días por semana";
			this.rbtn3.UseVisualStyleBackColor = true;
			this.rbtn3.CheckedChanged += new System.EventHandler(this.rbtn3_CheckedChanged);
			// 
			// rbtn2
			// 
			this.rbtn2.AutoSize = true;
			this.rbtn2.Location = new System.Drawing.Point(9, 47);
			this.rbtn2.Name = "rbtn2";
			this.rbtn2.Size = new System.Drawing.Size(261, 17);
			this.rbtn2.TabIndex = 2;
			this.rbtn2.Tag = "2";
			this.rbtn2.Text = "Algo activo: ejercicio ligero 1 a 3 días por semana";
			this.rbtn2.UseVisualStyleBackColor = true;
			this.rbtn2.CheckedChanged += new System.EventHandler(this.rbtn2_CheckedChanged);
			// 
			// rbtn1
			// 
			this.rbtn1.AutoSize = true;
			this.rbtn1.Location = new System.Drawing.Point(9, 20);
			this.rbtn1.Name = "rbtn1";
			this.rbtn1.Size = new System.Drawing.Size(200, 17);
			this.rbtn1.TabIndex = 1;
			this.rbtn1.Tag = "1";
			this.rbtn1.Text = "Sedentario: poco o nada de ejercicio";
			this.rbtn1.UseVisualStyleBackColor = true;
			this.rbtn1.CheckedChanged += new System.EventHandler(this.rbtn1_CheckedChanged);
			// 
			// gbResults
			// 
			this.gbResults.Controls.Add(this.lbBMIColor);
			this.gbResults.Controls.Add(this.lbCalories);
			this.gbResults.Controls.Add(this.labelControl3);
			this.gbResults.Controls.Add(this.labelControl2);
			this.gbResults.Controls.Add(this.lbBMI);
			this.gbResults.Location = new System.Drawing.Point(12, 330);
			this.gbResults.Name = "gbResults";
			this.gbResults.Size = new System.Drawing.Size(352, 75);
			this.gbResults.TabIndex = 3;
			this.gbResults.TabStop = false;
			this.gbResults.Text = "Resultados";
			// 
			// lbBMIColor
			// 
			this.lbBMIColor.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBMIColor.Appearance.Options.UseFont = true;
			this.lbBMIColor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lbBMIColor.Location = new System.Drawing.Point(141, 20);
			this.lbBMIColor.Name = "lbBMIColor";
			this.lbBMIColor.Size = new System.Drawing.Size(21, 21);
			this.lbBMIColor.TabIndex = 13;
			this.lbBMIColor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
			this.lbBMIColor.ToolTipTitle = "IMC";
			// 
			// lbCalories
			// 
			this.lbCalories.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCalories.Appearance.Options.UseFont = true;
			this.lbCalories.Appearance.Options.UseTextOptions = true;
			this.lbCalories.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.lbCalories.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lbCalories.Location = new System.Drawing.Point(60, 47);
			this.lbCalories.Name = "lbCalories";
			this.lbCalories.Size = new System.Drawing.Size(75, 21);
			this.lbCalories.TabIndex = 12;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(12, 51);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(42, 13);
			this.labelControl3.TabIndex = 11;
			this.labelControl3.Text = "Calorías:";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(12, 24);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(23, 13);
			this.labelControl2.TabIndex = 10;
			this.labelControl2.Text = "IMC:";
			// 
			// lbBMI
			// 
			this.lbBMI.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBMI.Appearance.Options.UseFont = true;
			this.lbBMI.Appearance.Options.UseTextOptions = true;
			this.lbBMI.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.lbBMI.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lbBMI.Location = new System.Drawing.Point(60, 20);
			this.lbBMI.Name = "lbBMI";
			this.lbBMI.Size = new System.Drawing.Size(75, 21);
			this.lbBMI.TabIndex = 9;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Management.Properties.Resources.imc;
			this.pictureBox1.Location = new System.Drawing.Point(370, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(464, 393);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(352, 65);
			this.label5.TabIndex = 5;
			this.label5.Text = resources.GetString("label5.Text");
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkMoreInfo
			// 
			this.linkMoreInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkMoreInfo.Location = new System.Drawing.Point(67, 61);
			this.linkMoreInfo.Name = "linkMoreInfo";
			this.linkMoreInfo.Size = new System.Drawing.Size(104, 13);
			this.linkMoreInfo.TabIndex = 6;
			this.linkMoreInfo.Text = "Más información aquí.";
			this.linkMoreInfo.Click += new System.EventHandler(this.linkMoreInfo_Click);
			// 
			// BMICalculatorView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(846, 430);
			this.Controls.Add(this.linkMoreInfo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.gbResults);
			this.Controls.Add(this.gbActivity);
			this.Controls.Add(this.gbMeasures);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "BMICalculatorView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculadora de IMC";
			this.Load += new System.EventHandler(this.BMICalculatorView_Load);
			this.gbMeasures.ResumeLayout(false);
			this.gbMeasures.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.gbActivity.ResumeLayout(false);
			this.gbActivity.PerformLayout();
			this.gbResults.ResumeLayout(false);
			this.gbResults.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion

      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private System.Windows.Forms.GroupBox gbMeasures;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ErrorProvider errorProvider;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.NumericUpDown numWeight;
      private System.Windows.Forms.NumericUpDown numHeight;
      private System.Windows.Forms.GroupBox gbActivity;
      private System.Windows.Forms.RadioButton rbtn5;
      private System.Windows.Forms.RadioButton rbtn4;
      private System.Windows.Forms.RadioButton rbtn3;
      private System.Windows.Forms.RadioButton rbtn2;
      private System.Windows.Forms.RadioButton rbtn1;
      private DevExpress.XtraEditors.HyperlinkLabelControl linkMoreInfo;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.GroupBox gbResults;
      private DevExpress.XtraEditors.LabelControl lbCalories;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private DevExpress.XtraEditors.LabelControl lbBMI;
      private DevExpress.XtraEditors.LabelControl lbBMIColor;
   }
}