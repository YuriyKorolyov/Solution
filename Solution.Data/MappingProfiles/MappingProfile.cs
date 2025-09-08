using AutoMapper;
using Solution.Data.Dto;
using Solution.Domain;

namespace Solution.Data.MappingProfiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>()
            .ForMember(dest => dest.DiscountPrice,
                opt => opt.MapFrom(src => src.SpecialPrice))
            .ForMember(dest => dest.IsAvailable,
                opt => opt.MapFrom(src => src.StockAvailability && src.IsPublished)) 
            .ForMember(dest => dest.TechnicalSpecs,
                opt => opt.MapFrom(src => $"{src.Processor}, {src.RAM}, {src.Storage}")); 

        CreateMap<User, UserDto>()
            .ForMember(dest => dest.OrderCount,
                opt => opt.MapFrom(src => src.Orders.Count));

        CreateMap<Order, OrderDto>()
            .ForMember(dest => dest.CustomerName,
                opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}")) 
            .ForMember(dest => dest.ItemCount,
                opt => opt.MapFrom(src => src.OrderItems.Sum(item => item.Quantity))); 

        CreateMap<OrderItem, OrderItemDto>()
            .ForMember(dest => dest.ProductName,
                opt => opt.MapFrom(src => src.Product.Name)) 
            .ForMember(dest => dest.TotalPrice,
                opt => opt.MapFrom(src => src.Quantity * src.UnitPrice));

        CreateMap<Customer, CustomerDto>()
            .ForMember(dest => dest.Email,
                opt => opt.MapFrom(src => src.User.Email)) 
            .ForMember(dest => dest.ContactName,
                opt => opt.MapFrom(src => src.ContactName ?? src.CompanyName)); 

        CreateMap<ProductDto, Product>()
            .ForMember(dest => dest.SpecialPrice,
                opt => opt.MapFrom(src => src.DiscountPrice))
            .ForMember(dest => dest.StockAvailability,
                opt => opt.MapFrom(src => src.IsAvailable))
            .ForMember(dest => dest.IsPublished,
                opt => opt.MapFrom(src => src.IsAvailable));

        CreateMap<UserDto, User>();
        CreateMap<OrderDto, Order>();
    }
}
