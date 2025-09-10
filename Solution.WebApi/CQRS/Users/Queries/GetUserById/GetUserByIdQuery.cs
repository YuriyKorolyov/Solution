using MediatR;
using Solution.Data.Dto;
namespace Solution.WebApi.CQRS.Users.Queries.GetUserDetails;

public class GetUserByIdQuery : IRequest<UserDto?>
{
    public int Id { get; init; }
}
