using FutbolTracking.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FutbolTracking.Application.Contracts;

public interface IApplicationDbContext
{
    DbSet<League> Leagues { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
