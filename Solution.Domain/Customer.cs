namespace Solution.Domain;

public class Customer
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string CustomerCode { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
    public string TaxId { get; set; }
    public string BankName { get; set; }
    public string BankAccount { get; set; }
    public string PaymentTerms { get; set; }
    public decimal CreditLimit { get; set; }
    public decimal CurrentBalance { get; set; }
    public DateTime CustomerSince { get; set; }
    public string CustomerType { get; set; }
    public string Industry { get; set; }
    public int EmployeeCount { get; set; }
    public decimal AnnualRevenue { get; set; }
    public string Notes { get; set; }
    public bool IsActive { get; set; }
    public DateTime LastContactDate { get; set; }

    public User User { get; set; }
}