using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;

namespace Corlib.Presenters
{
   public class PersonalTrainingRecordPresenter : IPersonalTrainingRecordPresenter
   {
      private readonly IPersonalTrainingRecordView _view;
      private IUnitOfWork _unitOfWork;
      private PersonalTrainingRecord _personalTrainingRecord;
      private int _memberId;
      private bool _isNewRecord;

      #region IPersonalTrainingRecordPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      public PersonalTrainingRecordPresenter(IPersonalTrainingRecordView view, PersonalTrainingRecordViewModel personalTrainingRecordViewModel, int memberId)
      {
         _view = view;
         _memberId = memberId;
         ServiceLocator.SetView(GetView());

         WireViewEvents();

         _isNewRecord = personalTrainingRecordViewModel == null;

         if (_isNewRecord)
            PrepareViewForNewRecord();
         else
            ShowRecordData(personalTrainingRecordViewModel);
      }

      private void WireViewEvents()
      {
         _view.SaveRecord += OnSaveRecord;
      }

      private void ShowRecordData(PersonalTrainingRecordViewModel personalTrainingRecordViewModel)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _personalTrainingRecord = _unitOfWork.PersonalTrainingRecords.Get(personalTrainingRecordViewModel.Id);
         }

         _view.Date = _personalTrainingRecord.Date;
         _view.Weight = _personalTrainingRecord.Weight;
         _view.MemberHeight = _personalTrainingRecord.Height;
         _view.Neck = _personalTrainingRecord.Neck;
         _view.Shoulders = _personalTrainingRecord.Shoulders;
         _view.Chest = _personalTrainingRecord.Chest;
         _view.Waist = _personalTrainingRecord.Waist;
         _view.Forearms = _personalTrainingRecord.Forearms;
         _view.Thighs = _personalTrainingRecord.Thighs;
         _view.Calves = _personalTrainingRecord.Calves;
         _view.Biceps = _personalTrainingRecord.Biceps;
         _view.Buttocks = _personalTrainingRecord.Buttocks;
         _view.Comment = _personalTrainingRecord.Comment;

         _view.ViewText = "Editar registro";
      }

      private void PrepareViewForNewRecord()
      {
         _view.ViewText = "Agregar registro";
      }

      private void OnSaveRecord()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            if (_isNewRecord)
               _personalTrainingRecord = new PersonalTrainingRecord();

            _personalTrainingRecord.MemberId = _memberId;
            _personalTrainingRecord.Date = _view.Date;
            _personalTrainingRecord.Weight = _view.Weight;
            _personalTrainingRecord.Height = _view.MemberHeight;
            _personalTrainingRecord.Neck = _view.Neck;
            _personalTrainingRecord.Shoulders = _view.Shoulders;
            _personalTrainingRecord.Chest = _view.Chest;
            _personalTrainingRecord.Waist = _view.Waist;
            _personalTrainingRecord.Forearms = _view.Forearms;
            _personalTrainingRecord.Thighs = _view.Thighs;
            _personalTrainingRecord.Calves = _view.Calves;
            _personalTrainingRecord.Biceps = _view.Biceps;
            _personalTrainingRecord.Buttocks = _view.Buttocks;
            _personalTrainingRecord.Comment = _view.Comment;

            if (_isNewRecord)
               _unitOfWork.PersonalTrainingRecords.Add(_personalTrainingRecord);

            _unitOfWork.Complete();
            _view.CloseView();
         }
      }
   }
}
