using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface IReportConfigurationView : IView
   {
      Report SelectedReport { get; }
      DateTime CheckinsDateFrom { get; }
      DateTime CheckinsDateTo { get; }
      DateTime SalesDateFrom { get; }
      DateTime SalesDateTo { get; }
      IEnumerable<TrainingViewModel> Trainings { get; set; }
      IEnumerable<TrainingViewModel> SelectedTrainings { get; }

      event Action ShowReport;
   }
}
