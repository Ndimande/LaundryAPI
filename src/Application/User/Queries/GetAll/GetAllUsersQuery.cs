
using AutoMapper;
using CA.Application.Requests.Dtos;
using CleanArchitecture.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CA.Application.Students.Queries.GetAll;

public class GetAllUsersQuery : IRequest<List<SignUpDto>>
{

}

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<SignUpDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUserService _currentUserService;
    private readonly IMapper _mapper;

    public GetAllUsersQueryHandler(IApplicationDbContext context, IMapper mapper, ICurrentUserService currentUserService)
    {
        _context = context;
        _mapper = mapper;
        _currentUserService = currentUserService;
    }
    public async Task<List<SignUpDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _context.SignUp
            .ToListAsync(cancellationToken: cancellationToken);

        var dto = new List<SignUpDto>();
        if (users != null)
        {
            foreach (var user in users)
            {
                dto.Add(new SignUpDto
                {
                    Contact = user.Contact,
                    Email = user.Email,
                    FirstName   = user.Firstname,
                    Id = user.Id,
                    LastName = user.Lastname,
                    Password = user.Password,
                    
                });
            }
        }

        return dto;
    }

}
