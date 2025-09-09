namespace Solution.Data.Dto;

public class ProductComplexDto
{
    public int ProductCode { get; set; }               // Id 
    public string Title { get; set; } = "";           // Name 
    public string FullDescription { get; set; } = ""; // Description 
    public string ShortDesc { get; set; } = "";       // ShortDescription 
    public string CategoryName { get; set; } = "";    // Category 
    public decimal RetailPrice { get; set; }          // Price 
    public decimal Wholesale { get; set; }            // WholesalePrice 
    public string VendorName { get; set; } = "";      // Vendor 
    public string ManufacturerName { get; set; } = ""; // Manufacturer 
    public string LicenseDetails { get; set; } = "";  // LicenseKey 
    public string ColorHex { get; set; } = "";        // Color 
    public bool AvailableForSale { get; set; }        // IsAvailable 
    public int QuantityInStock { get; set; }          // Stock 
    public string TagsCsv { get; set; } = "";         // Tags 
    public bool IsFeatured { get; set; }              // Featured
    public bool IsBestSeller { get; set; }            // BestSeller 
    public string SupportUrl { get; set; } = "";      // DocumentationUrl
    public string AdditionalNotes { get; set; } = ""; // Notes 

    // Поля, которые есть в модели, но переименованы в DTO
    public string CpuModel { get; set; } = "";        // CPU 
    public int RamGb { get; set; }                     // RAM_GB 
    public int StorageGb { get; set; }                // Storage_GB
    public string OsName { get; set; } = "";          // OS 
    public string GpuModel { get; set; } = "";        // GPU
    public string ConnectivityType { get; set; } = ""; // Connectivity
    public string PortsInfo { get; set; } = "";       // Ports
    public string SoftwareIncludedList { get; set; } = ""; // SoftwareIncluded 
}
