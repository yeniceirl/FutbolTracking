using FutbolTracking.Application.Contracts;
using FutbolTracking.Domain.Entities;
using FutbolTracking.Domain.ValueObjects;

namespace FutbolTracking.Application.Services;

public class LeagueService : ILeagueService
{
    private readonly IApplicationDbContext _context;

    public LeagueService(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<League> AddLeagueAsync(AddLeagueRequest request, CancellationToken cancellationToken = default)
    {
        var country = Country.List().First(c => c.Key.Equals(request.CountryKey, StringComparison.OrdinalIgnoreCase));
        var type = LeagueType.List().First(t => t.Key.Equals(request.TypeKey, StringComparison.OrdinalIgnoreCase));
        var rankin = Rankin.List().First(r => r.Key.Equals(request.RankinKey, StringComparison.OrdinalIgnoreCase));

        var league = new League
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Country = country,
            Type = type,
            Rankin = rankin,
            CreatedOn = DateTime.UtcNow,
            CreatedBy = request.CreatedBy
        };

        _context.Leagues.Add(league);
        await _context.SaveChangesAsync(cancellationToken);
        return league;
    }
}
