namespace Solution.Domain;

public class Customer
{
    public int Id { get; set; }
    public string CompanyName { get; set; } = "";
    public string ContactPerson { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Address { get; set; } = "";
    public string City { get; set; } = "";
    public string Region { get; set; } = "";
    public string INN { get; set; } = ""; // налоговый номер
    public string KPP { get; set; } = "";
    public decimal TotalSpent { get; set; }
    public int TotalOrders { get; set; }
    public bool VIPStatus { get; set; }
    public string Industry { get; set; } = ""; // IT, Telecom, FinTech
    public DateTime RegistrationDate { get; set; }
    public string Notes { get; set; } = "";

    public List<Order> Orders { get; set; } = new();
}
