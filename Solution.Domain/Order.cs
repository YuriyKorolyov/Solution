namespace Solution.Domain;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
    public DateTime OrderDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal Discount { get; set; }
    public string Status { get; set; } = ""; // Pending, Paid, Completed
    public string PaymentMethod { get; set; } = ""; // card, cash, invoice
    public string BillingAddress { get; set; } = "";
    public string ShippingAddress { get; set; } = "";
    public string Notes { get; set; } = "";

    public List<OrderItem> Items { get; set; } = new();
}
