using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Management.BMI
{
   public partial class BMICalculatorView : XtraForm, IBMICalculatorView
   {
      public BMICalculatorView()
      {
         InitializeComponent();
      }

      #region IBMICalculatorView
      public void CloseView()
      {
         Close();
      }

      public void Notify(string message, MessageType type)
      {
         var icon = MessageBoxIcon.Information;

         if (type == MessageType.Error)
            icon = MessageBoxIcon.Error;
         else if (type == MessageType.Warning)
            icon = MessageBoxIcon.Exclamation;

         XtraMessageBox.Show(message, AppConfig.AppName, MessageBoxButtons.OK, icon);
      }

      public bool Confirm(string message)
      {
         return XtraMessageBox.Show(message, AppConfig.AppName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
      }

      public void ShowView()
      {
         Show();
      }

      public event Func<decimal, decimal, decimal> CalculateBMI;
      public event Func<decimal, byte, decimal> CalculateCalories;
      public event Action MoreInfo;
      #endregion

      private void BMICalculatorView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;

         numWeight.Value = 80;
         numHeight.Value = 175;
      }

      private void numHeight_ValueChanged(object sender, EventArgs e)
      {
         Calculate();
      }

      private void numWeight_ValueChanged(object sender, EventArgs e)
      {
         Calculate();
      }

      private void rbtn1_CheckedChanged(object sender, EventArgs e)
      {
         Calculate();
      }

      private void rbtn2_CheckedChanged(object sender, EventArgs e)
      {
         Calculate();
      }

      private void rbtn3_CheckedChanged(object sender, EventArgs e)
      {
         Calculate();
      }

      private void rbtn4_CheckedChanged(object sender, EventArgs e)
      {
         Calculate();
      }

      private void rbtn5_CheckedChanged(object sender, EventArgs e)
      {
         Calculate();
      }

      private void linkMoreInfo_Click(object sender, EventArgs e)
      {
         MoreInfo();
      }

      #region Helpers
      private void Calculate()
      {
         lbBMI.Text = CalculateBMI(numWeight.Value, numHeight.Value).ToString();
         lbCalories.Text = CalculateCalories(numWeight.Value, GetActivityLevel()).ToString();
         SetBMIColor();
      }

      private byte GetActivityLevel()
      {
         return Convert.ToByte(gbActivity.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault().Tag);
      }

      private void SetBMIColor()
      {
         decimal.TryParse(lbBMI.Text, out decimal imc);

         if (imc <= 16) { lbBMIColor.BackColor = Color.Red; }
         if (imc >= 16 && imc <= 17) { lbBMIColor.BackColor = Color.Orange; }
         if (imc >= 17 && imc <= 18.49m) { lbBMIColor.BackColor = Color.GreenYellow; }
         if (imc >= 18.5m && imc <= 24.99m) { lbBMIColor.BackColor = Color.Green; }
         if (imc >= 25 && imc <= 29.99m) { lbBMIColor.BackColor = Color.GreenYellow; }
         if (imc >= 30 && imc <= 34.99m) { lbBMIColor.BackColor = Color.Orange; }
         if (imc >= 35 && imc <= 39.99m) { lbBMIColor.BackColor = Color.OrangeRed; }
         if (imc >= 40) { lbBMIColor.BackColor = Color.Red; }
      }
      #endregion
   }
}