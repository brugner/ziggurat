using System;

namespace Corlib.Views.Contracts
{
   public interface IContactView : IView
   {
      string ViewText { set; }

      int Id { get; set; }
      string ContactName { get; set; }
      string PhoneNumber1 { get; set; }
      string PhoneNumber2 { get; set; }
      bool IsDoctor { get; set; }

      event Action SaveContact;
   }
}
