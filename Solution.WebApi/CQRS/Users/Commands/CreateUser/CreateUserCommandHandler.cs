using MediatR;
using Microsoft.EntityFrameworkCore;
using Solution.Data;
using Solution.Domain;

namespace Solution.WebApi.CQRS.Users.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly AppDbContext _context;

    public CreateUserCommandHandler(AppDbContext context)
    {
        _context = context;
    }
    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        if (await _context.Users.AnyAsync(u => u.Email == request.Email, cancellationToken))
            throw new InvalidOperationException("User with this email already exists");

        var user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Phone = request.Phone,
            City = request.City,
            Region = request.Region,
            Company = request.Company,
            RegistrationDate = DateTime.UtcNow,
            IsVerified = false,
            OrderCount = 0,
            AccountBalance = 0,
            LastLogin = DateTime.UtcNow,
            Role = request.Role,
            Department = request.Department
        };

        await _context.Users.AddAsync(user, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return user.Id;
    }
}
