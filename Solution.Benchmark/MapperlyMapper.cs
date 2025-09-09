using Riok.Mapperly.Abstractions;
using Solution.Data.Dto;
using Solution.Domain;

namespace Solution.Benchmark;

[Mapper]
public partial class MapperlyMapper
{
    [MapperIgnoreTarget(nameof(User.Orders))]
    public partial User Map(UserDto userDto);

    [MapperIgnoreTarget(nameof(Customer.Orders))]
    public partial Customer Map(CustomerDto customerDto);
    public partial Product Map(ProductDto productDto);
    public partial OrderItem Map(OrderItemDto orderItemDto);
    public partial Order Map(OrderDto orderDto);  

    [MapProperty(nameof(ProductComplexDto.ProductCode), nameof(Product.Id))]
    [MapProperty(nameof(ProductComplexDto.Title), nameof(Product.Name))]
    [MapProperty(nameof(ProductComplexDto.FullDescription), nameof(Product.Description))]
    [MapProperty(nameof(ProductComplexDto.ShortDesc), nameof(Product.ShortDescription))]
    [MapProperty(nameof(ProductComplexDto.CategoryName), nameof(Product.Category))]
    [MapProperty(nameof(ProductComplexDto.RetailPrice), nameof(Product.Price))]
    [MapProperty(nameof(ProductComplexDto.Wholesale), nameof(Product.WholesalePrice))]
    [MapProperty(nameof(ProductComplexDto.VendorName), nameof(Product.Vendor))]
    [MapProperty(nameof(ProductComplexDto.ManufacturerName), nameof(Product.Manufacturer))]
    [MapProperty(nameof(ProductComplexDto.LicenseDetails), nameof(Product.LicenseKey))]
    [MapProperty(nameof(ProductComplexDto.ColorHex), nameof(Product.Color))]
    [MapProperty(nameof(ProductComplexDto.AvailableForSale), nameof(Product.IsAvailable))]
    [MapProperty(nameof(ProductComplexDto.QuantityInStock), nameof(Product.Stock))]
    [MapProperty(nameof(ProductComplexDto.TagsCsv), nameof(Product.Tags))]
    [MapProperty(nameof(ProductComplexDto.IsFeatured), nameof(Product.Featured))]
    [MapProperty(nameof(ProductComplexDto.IsBestSeller), nameof(Product.BestSeller))]
    [MapProperty(nameof(ProductComplexDto.SupportUrl), nameof(Product.DocumentationUrl))]
    [MapProperty(nameof(ProductComplexDto.AdditionalNotes), nameof(Product.Notes))]
    [MapProperty(nameof(ProductComplexDto.CpuModel), nameof(Product.CPU))]
    [MapProperty(nameof(ProductComplexDto.RamGb), nameof(Product.RAM_GB))]
    [MapProperty(nameof(ProductComplexDto.StorageGb), nameof(Product.Storage_GB))]
    [MapProperty(nameof(ProductComplexDto.OsName), nameof(Product.OS))]
    [MapProperty(nameof(ProductComplexDto.GpuModel), nameof(Product.GPU))]
    [MapProperty(nameof(ProductComplexDto.ConnectivityType), nameof(Product.Connectivity))]
    [MapProperty(nameof(ProductComplexDto.PortsInfo), nameof(Product.Ports))]
    [MapProperty(nameof(ProductComplexDto.SoftwareIncludedList), nameof(Product.SoftwareIncluded))]
    public partial Product Map(ProductComplexDto dto);
}