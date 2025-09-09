namespace Solution.Domain;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string SKU { get; set; } = "";
    public string Category { get; set; } = "";
    public string SubCategory { get; set; } = "";
    public string Vendor { get; set; } = "";
    public string Manufacturer { get; set; } = "";
    public string Brand { get; set; } = "";
    public string Model { get; set; } = "";
    public string Version { get; set; } = "";
    public string LicenseKey { get; set; } = "";

    public decimal Price { get; set; }
    public decimal Discount { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal CostPrice { get; set; }
    public decimal WholesalePrice { get; set; }

    public int Stock { get; set; }
    public bool IsAvailable { get; set; }
    public bool IsPreOrder { get; set; }
    public int MinOrderQuantity { get; set; }
    public int MaxOrderQuantity { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime ReleaseDate { get; set; }
    public DateTime ExpirationDate { get; set; }

    public string Description { get; set; } = "";
    public string ShortDescription { get; set; } = "";
    public string Features { get; set; } = "";
    public string Instructions { get; set; } = "";
    public string WarrantyInfo { get; set; } = "";
    public string Notes { get; set; } = "";

    public double WeightKg { get; set; }
    public double WidthCm { get; set; }
    public double HeightCm { get; set; }
    public double DepthCm { get; set; }
    public string Color { get; set; } = "";

    public string CPU { get; set; } = "";
    public int RAM_GB { get; set; }
    public int Storage_GB { get; set; }
    public string GPU { get; set; } = "";
    public string OS { get; set; } = "";
    public string Connectivity { get; set; } = "";
    public string Ports { get; set; } = "";
    public string SoftwareIncluded { get; set; } = "";

    public string LicenseType { get; set; } = "";
    public int LicenseDurationMonths { get; set; }
    public string Certification { get; set; } = "";
    public bool IsOpenSource { get; set; }

    public string Tags { get; set; } = "";
    public int Rating { get; set; }
    public int ReviewCount { get; set; }
    public int Views { get; set; }
    public int SalesCount { get; set; }

    public double ShippingWeightKg { get; set; }
    public string ShippingDimensions { get; set; } = "";
    public string WarehouseLocation { get; set; } = "";
    public bool FreeShipping { get; set; }
    public int DeliveryDays { get; set; }

    public bool Featured { get; set; }
    public bool NewArrival { get; set; }
    public bool BestSeller { get; set; }
    public string ReturnPolicy { get; set; } = "";
    public string SupportContact { get; set; } = "";
    public string DocumentationUrl { get; set; } = "";
}
