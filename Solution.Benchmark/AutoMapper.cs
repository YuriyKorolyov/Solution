using AutoMapper;
using Solution.Data.Dto;
using Solution.Domain;
using System.Text.Json;

namespace Solution.Benchmark;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<UserDto, User>();

        CreateMap<CustomerDto, Customer>();

        CreateMap<ProductDto, Product>();

        CreateMap<OrderItemDto, OrderItem>()
            .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));

        CreateMap<OrderDto, Order>()
            .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User))
            .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => src.Customer))
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));

        CreateMap<ProductComplexDto, Product>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ProductCode))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.FullDescription))
            .ForMember(dest => dest.ShortDescription, opt => opt.MapFrom(src => src.ShortDesc))
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.CategoryName))
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.RetailPrice))
            .ForMember(dest => dest.WholesalePrice, opt => opt.MapFrom(src => src.Wholesale))
            .ForMember(dest => dest.Vendor, opt => opt.MapFrom(src => src.VendorName))
            .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.ManufacturerName))
            .ForMember(dest => dest.LicenseKey, opt => opt.MapFrom(src => src.LicenseDetails))
            .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.ColorHex))
            .ForMember(dest => dest.IsAvailable, opt => opt.MapFrom(src => src.AvailableForSale))
            .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.QuantityInStock))
            .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.TagsCsv))
            .ForMember(dest => dest.Featured, opt => opt.MapFrom(src => src.IsFeatured))
            .ForMember(dest => dest.BestSeller, opt => opt.MapFrom(src => src.IsBestSeller))
            .ForMember(dest => dest.DocumentationUrl, opt => opt.MapFrom(src => src.SupportUrl))
            .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.AdditionalNotes))
            .ForMember(dest => dest.CPU, opt => opt.MapFrom(src => src.CpuModel))
            .ForMember(dest => dest.RAM_GB, opt => opt.MapFrom(src => src.RamGb))
            .ForMember(dest => dest.Storage_GB, opt => opt.MapFrom(src => src.StorageGb))
            .ForMember(dest => dest.OS, opt => opt.MapFrom(src => src.OsName))
            .ForMember(dest => dest.GPU, opt => opt.MapFrom(src => src.GpuModel))
            .ForMember(dest => dest.Connectivity, opt => opt.MapFrom(src => src.ConnectivityType))
            .ForMember(dest => dest.Ports, opt => opt.MapFrom(src => src.PortsInfo))
            .ForMember(dest => dest.SoftwareIncluded, opt => opt.MapFrom(src => src.SoftwareIncludedList));
    }
}
