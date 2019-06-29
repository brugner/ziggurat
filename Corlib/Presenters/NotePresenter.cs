using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System;

namespace Corlib.Presenters
{
   public class NotePresenter : INotePresenter
   {
      private readonly INoteView _view;
      private IUnitOfWork _unitOfWork;
      private Note _note;
      private int _memberId;
      private bool _isNewNote;

      public NotePresenter(INoteView view, NoteViewModel noteViewModel, int memberId)
      {
         _view = view;
         _memberId = memberId;
         ServiceLocator.SetView(GetView());

         WireViewEvents();

         _isNewNote = noteViewModel == null;

         if (_isNewNote)
            PrepareViewForNewNote();
         else
            ShowNoteData(noteViewModel);
      }

      private void WireViewEvents()
      {
         _view.SaveNote += OnSaveNote;
      }

      #region INotePresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void ShowNoteData(NoteViewModel noteViewModel)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _note = _unitOfWork.Notes.Get(noteViewModel.Id);
         }

         _view.Id = _note.Id;
         _view.NoteText = _note.Text;
         _view.Date = _note.Date;

         _view.ViewText = $"Editar nota";
      }

      private void PrepareViewForNewNote()
      {
         _view.ViewText = "Agregar nota";
      }

      private void OnSaveNote()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _note = _unitOfWork.Notes.Get(_view.Id);

            if (_isNewNote)
               _note = new Note();

            _note.MemberId = _memberId;
            _note.Text = _view.NoteText;
            _note.Date = DateTime.Now;

            if (_isNewNote)
               _unitOfWork.Notes.Add(_note);

            _unitOfWork.Complete();
            _view.CloseView();
         }
      }
   }
}
