using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface IMembershipView : IView
   {
      string ViewText { set; }

      int? Id { get; set; }
      IList<TrainingViewModel> Trainings { get; set; }
      int TrainingId { get; set; }
      int ShiftId { get; set; }
      int Length { get; set; }
      DateTime StartDate { get; set; }
      DateTime EndDate { get; set; }
      decimal Price { get; set; }
      byte Status { get; set; }
      bool IsFullyPaid { get; set; }

      void InitializeView();

      event Action SaveMembership;
   }
}
