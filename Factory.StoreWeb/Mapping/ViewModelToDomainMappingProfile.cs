using AutoMapper;
using Factory.StoreDomainModule.Entities;
using Factory.StoreWeb.Models;

namespace Factory.StoreWeb.Mapping
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ShopperViewModel, Shopper>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ShopperId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ShopperName));
        }
    }
}