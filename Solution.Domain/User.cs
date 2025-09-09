namespace Solution.Domain;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public string City { get; set; } = "";
    public string Region { get; set; } = "";
    public string Company { get; set; } = "";
    public DateTime RegistrationDate { get; set; }
    public bool IsVerified { get; set; }
    public int OrderCount { get; set; }
    public decimal AccountBalance { get; set; }
    public DateTime LastLogin { get; set; }
    public string Role { get; set; } = "";
    public string Department { get; set; } = "";

    public List<Order> Orders { get; set; } = new();
}
