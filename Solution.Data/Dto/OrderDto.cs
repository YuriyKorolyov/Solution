namespace Solution.Data.Dto;

public class OrderDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public UserDto User { get; set; } = null!;
    public int CustomerId { get; set; }
    public CustomerDto Customer { get; set; } = null!;
    public DateTime OrderDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal Discount { get; set; }
    public string Status { get; set; } = "";
    public string PaymentMethod { get; set; } = "";
    public string BillingAddress { get; set; } = "";
    public string ShippingAddress { get; set; } = "";
    public string Notes { get; set; } = "";

    public List<OrderItemDto> Items { get; set; } = new();
}
