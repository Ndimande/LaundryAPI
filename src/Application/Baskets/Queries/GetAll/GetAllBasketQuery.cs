
using AutoMapper;
using CA.Application.Requests.Dtos;
using CleanArchitecture.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CA.Application.Schools.Queries.GetAll;

public class GetAllBasketQuery : IRequest<List<BasketDto>>
{

}

public class GetAllBasketsQueryHandler : IRequestHandler<GetAllBasketQuery, List<BasketDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUserService _currentUserService;
    private readonly IMapper _mapper;

    public GetAllBasketsQueryHandler(IApplicationDbContext context, IMapper mapper, ICurrentUserService currentUserService)
    {
        _context = context;
        _mapper = mapper;
        _currentUserService = currentUserService;
    }
    public async Task<List<BasketDto>> Handle(GetAllBasketQuery request, CancellationToken cancellationToken)
    {
      //  var bask =  _context.Basket;     
        
        var baskets = await _context.Basket
            .ToListAsync(cancellationToken: cancellationToken);

        var dto = new List<BasketDto>();
        if (baskets != null)
        {
            foreach (var basket in baskets)
            {
                dto.Add(new BasketDto
                {
                    Id = basket.Id,
                    Size = basket.Size.Value,
                    ImageUrl = basket.ImageUrl,
                    EstimatedPrize = basket.EstimatedPrize,

                });
            }
        }

        return dto;
    }


}
