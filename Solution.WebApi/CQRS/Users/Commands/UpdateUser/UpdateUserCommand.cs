using MediatR;

namespace Solution.WebApi.CQRS.Users.Commands.UpdateUser;

public record UpdateUserCommand : IRequest<bool>
{
    public int Id { get; init; }
    public string FirstName { get; init; } = "";
    public string LastName { get; init; } = "";
    public string Phone { get; init; } = "";
    public string City { get; init; } = "";
    public string Region { get; init; } = "";
    public string Company { get; init; } = "";
    public string Role { get; init; } = "";
    public string Department { get; init; } = "";
}
