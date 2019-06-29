using System;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using System.IO;

namespace Corlib.Presenters
{
   class AdConfigurationPresenter : IAdConfigurationPresenter
   {
      private IAdConfigurationView _view;
      private IUnitOfWork _unitOfWork;
      private Ad _ad;

      public AdConfigurationPresenter(IAdConfigurationView view)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         ShowAdData();
      }

      #region IAdConfigurationPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void WireViewEvents()
      {
         _view.SaveAd += OnSaveAd;
      }

      private void OnSaveAd()
      {
         if (!_view.Confirm("¿Está seguro que desea guardar el anuncio?"))
            return;

         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _ad = _unitOfWork.Ads.Get();

            if (_ad == null)
               _ad = new Ad();

            _ad.AdText = _view.AdText;
            _ad.Image1Path = Helper.SavePictureAndGetPath(_view.Image1Path, Entity.Ad, null);
            _ad.Image1SizeMode = _view.Image1SizeMode;
            _ad.Image2Path = Helper.SavePictureAndGetPath(_view.Image2Path, Entity.Ad, null);
            _ad.Image2SizeMode = _view.Image2SizeMode;
            _ad.Image3Path = Helper.SavePictureAndGetPath(_view.Image3Path, Entity.Ad, null);
            _ad.Image3SizeMode = _view.Image3SizeMode;
            _ad.StartDate = _view.StartDate;
            _ad.EndDate = _view.EndDate;

            if (_ad.Id == 0)
               _unitOfWork.Ads.Add(_ad);

            _unitOfWork.Complete();
            DeleteOldFiles();
            _view.Notify("El anuncio se guardó exitosamente", MessageType.Information);
            _view.CloseView();
         }
      }

      private void ShowAdData()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _ad = _unitOfWork.Ads.Get();

            if (_ad == null)
               return;

            _view.AdText = _ad.AdText;
            _view.Image1Path = _ad.Image1Path;
            _view.Image1SizeMode = _ad.Image1SizeMode;
            _view.Image2Path = _ad.Image2Path;
            _view.Image2SizeMode = _ad.Image2SizeMode;
            _view.Image3Path = _ad.Image3Path;
            _view.Image3SizeMode = _ad.Image3SizeMode;
            _view.StartDate = _ad.StartDate;
            _view.EndDate = _ad.EndDate;
         }
      }

      private void DeleteOldFiles()
      {
         var directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "ads");
         var di = new DirectoryInfo(directoryPath);

         foreach (var file in di.GetFiles())
         {
            if (file.FullName != _ad.Image1Path && file.FullName != _ad.Image2Path && file.FullName != _ad.Image3Path)
            {
               try
               {
                  file.Delete();
               }
               catch (Exception)
               {
                  
               }
            }
         }
      }
   }
}
