namespace Corlib.Views.ViewModels
{
   public class SaleItemViewModel : ViewModel
   {
      public int ProductId { get; set; }
      public string ProductName { get; set; }
      public decimal Price { get; set; }
      public byte Quantity { get; set; }
      public decimal Subtotal { get; set; }
   }
}
