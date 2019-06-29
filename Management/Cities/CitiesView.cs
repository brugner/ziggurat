using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Management.Cities
{
   public partial class CitiesView : XtraForm, ICitiesView
   {
      public CitiesView()
      {
         InitializeComponent();
      }

      #region ICitiesView
      public IEnumerable<CityViewModel> Cities
      {
         get { return (IEnumerable<CityViewModel>)gridControlCities.DataSource; }
         set { gridControlCities.DataSource = value; }
      }

      public CityViewModel SelectedCity
      {
         get { return GetSelectedCity(); }
      }

      public void CloseView()
      {
         Close();
      }

      public void Notify(string message, MessageType type)
      {

      }

      public bool Confirm(string message)
      {
         return true;
      }

      public void ShowView()
      {
         ShowDialog();
      }

      public event Action CitySelected;
      #endregion

      private void CitiesView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void gridViewCities_DoubleClick(object sender, EventArgs e)
      {
         CitySelected();
      }

      private CityViewModel GetSelectedCity()
      {
         if (gridControlCities.MainView.RowCount == 0)
            return null;

         var selectedRow = ((GridView)gridControlCities.MainView).GetSelectedRows().First();
         var selectedCity = (CityViewModel)(((GridView)gridControlCities.MainView).GetRow(selectedRow));
         return selectedCity;
      }
   }
}