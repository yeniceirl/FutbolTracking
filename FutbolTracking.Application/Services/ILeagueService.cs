using FutbolTracking.Application.Contracts;
using FutbolTracking.Domain.Entities;

namespace FutbolTracking.Application.Services;

public interface ILeagueService
{
    Task<League> AddLeagueAsync(AddLeagueRequest request, CancellationToken cancellationToken = default);
}
