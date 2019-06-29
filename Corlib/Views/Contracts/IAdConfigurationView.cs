using System;

namespace Corlib.Views.Contracts
{
   public interface IAdConfigurationView : IView
   {
      string AdText { get; set; }
      string Image1Path { get; set; }
      byte Image1SizeMode { get; set; }
      string Image2Path { get; set; }
      byte Image2SizeMode { get; set; }
      string Image3Path { get; set; }
      byte Image3SizeMode { get; set; }
      DateTime StartDate { get; set; }
      DateTime EndDate { get; set; }

      event Action SaveAd;
   }
}
