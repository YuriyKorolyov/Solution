namespace Solution.Domain;

public class Order
{
    public int Id { get; set; }
    public string OrderNumber { get; set; }
    public int UserId { get; set; } 
    public DateTime OrderDate { get; set; }
    public DateTime? ShipDate { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public string Status { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal ShippingCost { get; set; }
    public string ShippingAddress { get; set; }
    public string PaymentMethod { get; set; }
    public string PaymentStatus { get; set; }
    public string Notes { get; set; }
    public bool IsGift { get; set; }
    public string DiscountCode { get; set; }
    public decimal DiscountAmount { get; set; }
    public DateTime CreatedAt { get; set; }

    public User User { get; set; }
    public List<OrderItem> OrderItems { get; set; } = new();
}

public class OrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }

    public Order Order { get; set; }
    public Product Product { get; set; }
}
