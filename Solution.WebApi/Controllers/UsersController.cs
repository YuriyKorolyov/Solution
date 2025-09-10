using MediatR;
using Microsoft.AspNetCore.Mvc;
using Solution.WebApi.CQRS.Users.Commands.CreateUser;
using Solution.WebApi.CQRS.Users.Commands.DeleteUser;
using Solution.WebApi.CQRS.Users.Commands.UpdateUser;
using Solution.WebApi.CQRS.Users.Queries.GetUserDetails;

namespace Solution.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser(int id)
    {
        var user = await _mediator.Send(new GetUserByIdQuery { Id = id });
        return user != null ? Ok(user) : NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
    {
        try
        {
            var userId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetUser), new { id = userId }, null);
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, [FromBody] UpdateUserCommand command)
    {
        var result = await _mediator.Send(command with { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var result = await _mediator.Send(new DeleteUserCommand { Id = id });
        return result ? NoContent() : NotFound();
    }
}
