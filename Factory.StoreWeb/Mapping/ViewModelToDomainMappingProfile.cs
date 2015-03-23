using AutoMapper;
using Factory.StoreDomainModule.Entities;
using Factory.StoreServicesModule.DTOs;
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
            //TODO Здесь мапим только *DTO!!!!!!!!

            Mapper.CreateMap<ShopperDTO, Shopper>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ShopperId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ShopperName));

            Mapper.CreateMap<BidDTO, SerialBid>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.BidId));
        }
    }
}