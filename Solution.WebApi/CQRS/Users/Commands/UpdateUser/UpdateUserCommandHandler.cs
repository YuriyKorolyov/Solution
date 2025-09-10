using MediatR;
using Solution.Data;

namespace Solution.WebApi.CQRS.Users.Commands.UpdateUser;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
{
    private readonly AppDbContext _context;

    public UpdateUserCommandHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _context.Users.FindAsync(new object[] { request.Id }, cancellationToken);
        if (user == null) return false;

        user.FirstName = request.FirstName;
        user.LastName = request.LastName;
        user.Phone = request.Phone;
        user.City = request.City;
        user.Region = request.Region;
        user.Company = request.Company;
        user.Role = request.Role;
        user.Department = request.Department;

        _context.Users.Update(user);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
