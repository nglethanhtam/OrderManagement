using AutoMapper;
using OrderManagement.Domain;
using OrderManagement.Shared.DTOs.Order;
using OrderManagement.Shared.DTOs.Product;

namespace OrderManagement.API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductCreationRequest>().ReverseMap();
            CreateMap<Product, ProductCreationResponse>().ReverseMap();
            CreateMap<Product, ProductModificationRequest>().ReverseMap();
            CreateMap<Product, ProductModificationResponse>().ReverseMap();
            CreateMap<Product, ProductViewModel>().ReverseMap();

            CreateMap<OrderDetail, OrderCreationRequest>().ReverseMap();
            CreateMap<Order, OrderCreationResponse>().ReverseMap();
            CreateMap<Order, OrderViewModel>().ReverseMap();

        }
    }
}
