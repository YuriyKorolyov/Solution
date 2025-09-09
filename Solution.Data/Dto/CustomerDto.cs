namespace Solution.Data.Dto;

public class CustomerDto
{
    public int Id { get; set; }
    public string CompanyName { get; set; } = "";
    public string ContactPerson { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Address { get; set; } = "";
    public string City { get; set; } = "";
    public string Region { get; set; } = "";
    public string INN { get; set; } = "";
    public string KPP { get; set; } = "";
    public decimal TotalSpent { get; set; }
    public int TotalOrders { get; set; }
    public bool VIPStatus { get; set; }
    public string Industry { get; set; } = "";
    public DateTime RegistrationDate { get; set; }
    public string Notes { get; set; } = "";
}