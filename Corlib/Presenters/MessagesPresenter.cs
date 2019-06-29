using AutoMapper;
using Corlib.Builders;
using Corlib.Core;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System.Collections.Generic;

namespace Corlib.Presenters
{
   class MessagesPresenter : IMessagesPresenter
   {
      private readonly IMessagesView _view;
      private IUnitOfWork _unitOfWork;

      public MessagesPresenter(IMessagesView view)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         _view.InitializeView();
         ReloadMessagesList();
      }

      #region IMessagesPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void ReloadMessagesList()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var messages = _unitOfWork.Messages.GetAll();
            var messageViewModel = Mapper.Map<IEnumerable<MessageViewModel>>(messages);

            foreach (var message in messageViewModel)
            {
               foreach (var id in message.RecipientsIds)
                  message.RecipientsNames += _unitOfWork.Members.GetFullName(id) + ", ";

               message.RecipientsNames = message.RecipientsNames.Remove(message.RecipientsNames.Length - 2);
            }

            _view.Messages = messageViewModel;
         }
      }

      private void WireViewEvents()
      {
         _view.ShowMessage += OnShowMessage;
      }

      private void OnShowMessage(object sender, EventArgs<MessageViewModel> e)
      {
         PresenterBuilder<IMessagePresenter, IMessageView>.Build(e.Value, 1).ShowView();
         ReloadMessagesList();
      }
   }
}
