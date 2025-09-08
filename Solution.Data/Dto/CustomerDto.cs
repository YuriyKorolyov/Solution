namespace Solution.Data.Dto;

public class CustomerDto
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public decimal CreditLimit { get; set; }
    public bool IsActive { get; set; }
}