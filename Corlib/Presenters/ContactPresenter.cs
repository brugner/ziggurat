using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;

namespace Corlib.Presenters
{
   public class ContactPresenter : IContactPresenter
   {
      private readonly IContactView _view;
      private IUnitOfWork _unitOfWork;
      private Contact _contact;
      private int _memberId;
      private bool _isNewContact;

      public ContactPresenter(IContactView view, ContactViewModel contactViewModel, int memberId)
      {
         _view = view;
         _memberId = memberId;
         ServiceLocator.SetView(GetView());

         WireViewEvents();

         _isNewContact = contactViewModel == null;

         if (_isNewContact)
            PrepareViewForNewContact();
         else
            ShowContactData(contactViewModel);
      }

      private void WireViewEvents()
      {
         _view.SaveContact += OnSaveContact;
      }

      #region IContactPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void ShowContactData(ContactViewModel contactViewModel)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _contact = _unitOfWork.Contacts.Get(contactViewModel.Id);
         }

         _view.Id = _contact.Id;
         _view.ContactName = _contact.Name;
         _view.PhoneNumber1 = _contact.PhoneNumber1;
         _view.PhoneNumber2 = _contact.PhoneNumber2;
         _view.IsDoctor = _contact.IsDoctor;

         _view.ViewText = $"{_contact.Name}";
      }

      private void PrepareViewForNewContact()
      {
         _view.ViewText = "Agregar contacto";
      }

      private void OnSaveContact()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _contact = _unitOfWork.Contacts.Get(_view.Id);

            if (_isNewContact)
               _contact = new Contact();

            _contact.MemberId = _memberId;
            _contact.Name = _view.ContactName;
            _contact.PhoneNumber1 = _view.PhoneNumber1;
            _contact.PhoneNumber2 = _view.PhoneNumber2;
            _contact.IsDoctor = _view.IsDoctor;

            if (_isNewContact)
               _unitOfWork.Contacts.Add(_contact);

            _unitOfWork.Complete();
            _view.CloseView();
         }
      }
   }
}
