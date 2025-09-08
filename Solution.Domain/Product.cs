namespace Solution.Domain;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ShortDescription { get; set; }

    public decimal Price { get; set; }
    public decimal? OldPrice { get; set; }
    public decimal? SpecialPrice { get; set; }
    public DateTime? SpecialPriceStartDate { get; set; }
    public DateTime? SpecialPriceEndDate { get; set; }
    public decimal CostPrice { get; set; }
    public decimal Margin { get; set; }
    public decimal TaxRate { get; set; }
    public decimal Weight { get; set; }
    public decimal Length { get; set; }
    public decimal Width { get; set; }
    public decimal Height { get; set; }

    public string Category { get; set; }
    public string Subcategory { get; set; }
    public string Brand { get; set; }
    public string Manufacturer { get; set; }
    public string Supplier { get; set; }
    public string ProductType { get; set; }
    public string Tags { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }
    public string Material { get; set; }

    public int StockQuantity { get; set; }
    public int MinStockQuantity { get; set; }
    public int LowStockActivity { get; set; }
    public bool ManageStock { get; set; }
    public bool StockAvailability { get; set; }
    public int BackorderLimit { get; set; }
    public bool AllowBackorders { get; set; }
    public string WarehouseLocation { get; set; }
    public string ShelfNumber { get; set; }

    public string Processor { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }
    public string Display { get; set; }
    public string Graphics { get; set; }
    public string OperatingSystem { get; set; }
    public string BatteryLife { get; set; }
    public string Connectivity { get; set; }
    public string Ports { get; set; }
    public string Camera { get; set; }
    public string Sensors { get; set; }

    public string MainImageUrl { get; set; }
    public string AdditionalImages { get; set; }
    public string VideoUrl { get; set; }
    public string DocumentationUrl { get; set; }

    public bool IsPublished { get; set; }
    public bool IsFeatured { get; set; }
    public bool IsNew { get; set; }
    public bool IsOnSale { get; set; }
    public bool IsDownloadable { get; set; }
    public bool IsVirtual { get; set; }
    public bool RequiresShipping { get; set; }
    public bool IsGiftCard { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime? AvailableStartDate { get; set; }
    public DateTime? AvailableEndDate { get; set; }

    public double Rating { get; set; }
    public int ReviewCount { get; set; }
    public int ViewCount { get; set; }
    public int SoldCount { get; set; }

    public string MetaTitle { get; set; }
    public string MetaDescription { get; set; }
    public string MetaKeywords { get; set; }
    public string UrlSlug { get; set; }

    public List<OrderItem> OrderItems { get; set; } = new();
}
