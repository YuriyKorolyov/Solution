namespace Solution.Domain;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public DateTime RegistrationDate { get; set; }
    public bool IsVerified { get; set; }
    public decimal AccountBalance { get; set; }
    public int LoginCount { get; set; }

    public List<Order> Orders { get; set; } = new();
    public List<Customer> Customers { get; set; } = new();
}