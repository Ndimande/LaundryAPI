using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<SignUp> SignUp { get; }

    DbSet<Booking> Booking { get; }

    DbSet<Basket> Basket { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
