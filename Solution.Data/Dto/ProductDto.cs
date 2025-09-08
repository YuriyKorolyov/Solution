namespace Solution.Data.Dto;

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal? DiscountPrice { get; set; }
    public int StockQuantity { get; set; }
    public string Category { get; set; }
    public string Brand { get; set; }
    public string SKU { get; set; }
    public bool IsAvailable { get; set; }
    public float Rating { get; set; }
    public string ImageUrl { get; set; }
    public string TechnicalSpecs { get; set; }
    public DateTime CreatedDate { get; set; }
}
