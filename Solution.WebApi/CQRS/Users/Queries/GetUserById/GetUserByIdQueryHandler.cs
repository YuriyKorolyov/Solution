using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Solution.Data;
using Solution.Data.Dto;
using Solution.WebApi.CQRS.Users.Queries.GetUserDetails;

namespace Solution.WebApi.CQRS.Users.Queries.GetUserById;

public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDto?>
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper; 

    public GetUserByIdQueryHandler(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<UserDto?> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        return await _context.Users
        .Where(u => u.Id == request.Id)
        .ProjectTo<UserDto>(_mapper.ConfigurationProvider) 
        .FirstOrDefaultAsync(cancellationToken);
    }
}
