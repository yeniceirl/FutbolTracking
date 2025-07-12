using FutbolTracking.Domain.ValueObjects;

namespace FutbolTracking.Domain.Entities;

public class League : BaseAuditableEntity
{
    public required string Name { get; set; }

    public required Country Country { get; set; }
    public required LeagueType Type { get; set; }
    public required Rankin Rankin { get; set; }
}
