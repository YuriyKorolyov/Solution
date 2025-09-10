using MediatR;

namespace Solution.WebApi.CQRS.Users.Commands.CreateUser;

public class CreateUserCommand : IRequest<int>
{
    public string FirstName { get; init; } = "";
    public string LastName { get; init; } = "";
    public string Email { get; init; } = "";
    public string Phone { get; init; } = "";
    public string City { get; init; } = "";
    public string Region { get; init; } = "";
    public string Company { get; init; } = "";
    public string Role { get; init; } = "";
    public string Department { get; init; } = "";
}
