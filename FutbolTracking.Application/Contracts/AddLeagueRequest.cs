namespace FutbolTracking.Application.Contracts;

public record AddLeagueRequest(
    string Name,
    string CountryKey,
    string TypeKey,
    string RankinKey,
    Guid CreatedBy);
