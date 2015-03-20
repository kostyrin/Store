using AutoMapper;
using Factory.StoreDomainModule.Entities;
using Factory.StoreWeb.Models;
using Factory.StoreWeb.Models.Bids;
using Factory.StoreWeb.ViewModels;

namespace Factory.StoreWeb.Mapping
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            //Mapper.CreateMap<ParentDto, Parent>()
            //.ForMember(m => m.Children, o => o.Ignore()) // To avoid automapping attempt
            //.AfterMap((p, o) => { o.Children = ToISet<ChildDto, Child>(p.Children); });

            Mapper.CreateMap<Shopper, ShopperViewModel>()
                  .ForMember(dest => dest.ShopperId, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dest => dest.ShopperName, opt => opt.MapFrom(src => src.Name));
            Mapper.CreateMap<Shopper, ShopperFormModel>()
                  .ForMember(dest => dest.ShopperId, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dest => dest.ShopperName, opt => opt.MapFrom(src => src.Name));

            Mapper.CreateMap<SerialBid, BidListModel>()
                  .ForMember(dest => dest.BidId, opt => opt.MapFrom(src => src.Id));
            Mapper.CreateMap<SerialBid, BidModel>()
                  .ForMember(dest => dest.BidId, opt => opt.MapFrom(src => src.Id));
            Mapper.CreateMap<SerialBidDetail, BidModel.BidDetailModel>()
                .ForMember(dest => dest.BidDetailId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName));


        }

    }
}