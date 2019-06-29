using AutoMapper;
using Corlib.Builders;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Corlib.Presenters
{
   class MessagePresenter : IMessagePresenter
   {
      private readonly IMessageView _view;
      private IUnitOfWork _unitOfWork;
      private Message _message;
      private bool _isNewMessage;

      public MessagePresenter(IMessageView view, MessageViewModel messageViewModel, int flag)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         _view.InitializeView();

         _isNewMessage = messageViewModel == null;

         if (_isNewMessage)
            PrepareViewForNewMessage();
         else
            ShowMessageData(messageViewModel);
      }

      public MessagePresenter(IMessageView view, MemberViewModel memberViewModel) : this(view, messageViewModel: null, flag: 1)
      {
         var recipients = _view.Recipients?.ToList() ?? new List<MemberViewModel>();
         recipients.Add(memberViewModel);
         _view.Recipients = recipients.AsEnumerable();
      }

      #region IMessagePresenter
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
         _view.AddRecipient += OnAddRecipient;
         _view.AddAllRecipients += OnAddAllRecipients;
         _view.RemoveAllRecipients += OnRemoveAllRecipients;
         _view.RemoveOneRecipient += OnRemoveOneRecipient;
         _view.SendMessage += OnSendMessage;
      }

      private void OnAddRecipient()
      {
         var presenter = PresenterBuilder<IMemberSearchPresenter, IMemberSearchView>.Build();
         presenter.ShowView();


         if (presenter.SelectedMember != null && _view.Recipients?.FirstOrDefault(x => x.Id == presenter.SelectedMember.Id) == null)
         {
            var recipients = _view.Recipients?.ToList() ?? new List<MemberViewModel>();
            recipients.Add(presenter.SelectedMember);
            _view.Recipients = recipients.AsEnumerable();
         }
      }

      private void OnAddAllRecipients()
      {
         _view.Recipients = null;

         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var members = _unitOfWork.Members.GetAll();
            var membersViewModels = Mapper.Map<IEnumerable<Member>, IEnumerable<MemberViewModel>>(members);
            _view.Recipients = membersViewModels;
         }
      }

      private void OnRemoveOneRecipient(EventArgs<MemberViewModel> e)
      {
         var recipients = _view.Recipients.ToList();
         recipients.Remove(e.Value);

         _view.Recipients = recipients.AsEnumerable();
      }

      private void OnRemoveAllRecipients()
      {
         _view.Recipients = null;
      }

      private void OnSendMessage()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _message = new Message();
            _message.Subject = _view.Subject;
            _message.Body = _view.MessageBody;
            _message.Date = DateTime.Now;
            _message.Recipients = _view.Recipients.Select(x => x.Id).ToArray();
            _unitOfWork.Messages.Add(_message);
            _unitOfWork.Complete();

            _view.Notify("El mensaje fue enviado exitosamente", MessageType.Information);
            _view.CloseView();
         }
      }

      private void ShowMessageData(MessageViewModel messageViewModel)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _message = _unitOfWork.Messages.Get(messageViewModel.Id);


            _view.Subject = _message.Subject;
            _view.MessageBody = _message.Body;
            _view.Date = _message.Date;

            var recipients = _unitOfWork.Members.GetAll(_message.Recipients);
            _view.Recipients = Mapper.Map<IEnumerable<MemberViewModel>>(recipients);

            _view.DisableFields();
            _view.ViewText = _message.Body;
         }
      }

      private void PrepareViewForNewMessage()
      {
         _view.ViewText = "Nuevo mensaje";
      }

   }
}
