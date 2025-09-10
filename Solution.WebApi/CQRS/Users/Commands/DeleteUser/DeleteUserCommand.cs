using MediatR;

namespace Solution.WebApi.CQRS.Users.Commands.DeleteUser;

public record DeleteUserCommand : IRequest<bool>
{
    public int Id { get; init; }
}
