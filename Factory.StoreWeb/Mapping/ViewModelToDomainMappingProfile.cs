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
            //TODO Здесь мапим только *FormModel!!!!!!!!

            Mapper.CreateMap<ShopperFormModel, Shopper>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ShopperId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ShopperName));

            Mapper.CreateMap<BidFormModel, SerialBid>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.BidId));
        }
    }
}