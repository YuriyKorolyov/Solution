namespace Solution.Data.Dto;

public class UserDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string City { get; set; }
    public DateTime RegistrationDate { get; set; }
    public bool IsVerified { get; set; }
    public int OrderCount { get; set; }
}