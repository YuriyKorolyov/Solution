namespace Solution.Data.Dto;

public class OrderItemDto
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public ProductDto Product { get; set; } = null!;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Total => Quantity * UnitPrice;
    public bool IsGift { get; set; }
    public string LicenseInfo { get; set; } = "";
    public DateTime AddedAt { get; set; }
}
