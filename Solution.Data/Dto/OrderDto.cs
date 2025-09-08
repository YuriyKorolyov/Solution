namespace Solution.Data.Dto;

public class OrderDto
{
    public int Id { get; set; }
    public string OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public string Status { get; set; }
    public decimal TotalAmount { get; set; }
    public string CustomerName { get; set; }
    public string ShippingAddress { get; set; }
    public int ItemCount { get; set; }
}
