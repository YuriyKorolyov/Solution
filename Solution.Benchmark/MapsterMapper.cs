using Mapster;
using Solution.Data.Dto;
using Solution.Domain;

namespace Solution.Benchmark;

public static class MapsterMapper
{
    public static void RegisterMappings()
    {
        TypeAdapterConfig<ProductComplexDto, Product>.NewConfig()
            .Map(dest => dest.Id, src => src.ProductCode)
            .Map(dest => dest.Name, src => src.Title)
            .Map(dest => dest.Description, src => src.FullDescription)
            .Map(dest => dest.ShortDescription, src => src.ShortDesc)
            .Map(dest => dest.Category, src => src.CategoryName)
            .Map(dest => dest.Price, src => src.RetailPrice)
            .Map(dest => dest.WholesalePrice, src => src.Wholesale)
            .Map(dest => dest.Vendor, src => src.VendorName)
            .Map(dest => dest.Manufacturer, src => src.ManufacturerName)
            .Map(dest => dest.LicenseKey, src => src.LicenseDetails)
            .Map(dest => dest.Color, src => src.ColorHex)
            .Map(dest => dest.IsAvailable, src => src.AvailableForSale)
            .Map(dest => dest.Stock, src => src.QuantityInStock)
            .Map(dest => dest.Tags, src => src.TagsCsv)
            .Map(dest => dest.Featured, src => src.IsFeatured)
            .Map(dest => dest.BestSeller, src => src.IsBestSeller)
            .Map(dest => dest.DocumentationUrl, src => src.SupportUrl)
            .Map(dest => dest.Notes, src => src.AdditionalNotes)
            .Map(dest => dest.CPU, src => src.CpuModel)
            .Map(dest => dest.RAM_GB, src => src.RamGb)
            .Map(dest => dest.Storage_GB, src => src.StorageGb)
            .Map(dest => dest.OS, src => src.OsName)
            .Map(dest => dest.GPU, src => src.GpuModel)
            .Map(dest => dest.Connectivity, src => src.ConnectivityType)
            .Map(dest => dest.Ports, src => src.PortsInfo)
            .Map(dest => dest.SoftwareIncluded, src => src.SoftwareIncludedList);
    }
}
