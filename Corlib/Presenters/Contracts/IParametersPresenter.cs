namespace Corlib.Presenters.Contracts
{
   interface IParametersPresenter : IPresenter
   {
      bool ParametersChanged { get; set; }
   }
}
