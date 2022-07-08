
using AutoMapper;
using CA.Application.Requests.Dtos;
using CleanArchitecture.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CA.Application.Schools.Queries.GetAll;

public class GetAllBookingQuery : IRequest<List<BookingDto>>
{

}

public class GetAllBookingsQueryHandler : IRequestHandler<GetAllBookingQuery, List<BookingDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUserService _currentUserService;
    private readonly IMapper _mapper;

    public GetAllBookingsQueryHandler(IApplicationDbContext context, IMapper mapper, ICurrentUserService currentUserService)
    {
        _context = context;
        _mapper = mapper;
        _currentUserService = currentUserService;
    }
    public async Task<List<BookingDto>> Handle(GetAllBookingQuery request, CancellationToken cancellationToken)
    {
        var bookings = await _context.Booking
            .ToListAsync(cancellationToken: cancellationToken);

        var dto = new List<BookingDto>();
        if (bookings != null)
        {
            foreach (var book in bookings)
            {
                dto.Add(new BookingDto
                {
                    Id = book.Id,
                   BusketSize = book.BusketSize.Value,
                   NoOfBasket= book.NoOfBasket,
                   PickUpDate = book.PickUpDate,
                   PickUpTime = book.PickUpDate,
                   SignUpId = book.UserId,
                   Prize =  book.EstimatedPrize,

                });
            }
        }

        return dto;
    }


}
