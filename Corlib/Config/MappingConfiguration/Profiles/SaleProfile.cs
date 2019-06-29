using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;
using System.Linq;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class SaleProfile : Profile
   {
      public SaleProfile()
      {
         CreateMap<Sale, SaleViewModel>()
            .ForMember(dest => dest.Id, input => input.MapFrom(i => i.Id))
            .ForMember(dest => dest.Number, input => input.MapFrom(i => i.Number))
            .ForMember(dest => dest.Date, input => input.MapFrom(i => i.Date))

            .ForMember(dest => dest.MemberName, opt => opt.ResolveUsing(src =>
            {
               return src.Member.FirstName + " " + src.Member.LastName;
            }))

            .ForMember(dest => dest.Summary, opt => opt.ResolveUsing(src =>
            {
               string summary = string.Empty;

               foreach (var item in src.SaleItems)
                  summary += $"{item.Product.Name} x{item.Quantity}, ";

               return summary.Remove(summary.Length - 2, 2);
            }))

            .ForMember(dest => dest.Amount, opt => opt.ResolveUsing(src =>
            {
               return src.SaleItems.Sum(x => x.Price * x.Quantity);
            }));

         CreateMap<Sale, DebtViewModel>()
           .ForMember(dest => dest.IsSelected, opt => opt.MapFrom(x => false))
           .ForMember(dest => dest.SaleId, opt => opt.MapFrom(x => x.Id))
           .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
           .ForMember(dest => dest.Origin, opt => opt.MapFrom(x => "Venta"))
           .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.SaleItems.Sum(x => x.Price * x.Quantity)))

           .ForMember(dest => dest.Description, opt => opt.ResolveUsing(src =>
           {
              return $"Venta #{src.Number}";
           }))

           .ForMember(dest => dest.DebtAmount, opt => opt.ResolveUsing(src =>
           {
              var payed = src.Payments.Sum(x => x.Amount);
              return src.SaleItems.Sum(x => x.Price * x.Quantity) - payed;
           }));
      }
   }
}
