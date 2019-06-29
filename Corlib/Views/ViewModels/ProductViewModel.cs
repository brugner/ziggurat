namespace Corlib.Views.ViewModels
{
   public class ProductViewModel : ViewModel
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public decimal Price { get; set; }
      public string ProductType { get; set; }
      public bool IsActive { get; set; }
   }
}
