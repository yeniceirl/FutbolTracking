namespace FutbolTracking.Domain.ValueObjects;

public record LeagueType(Guid Id, string Key, string Value)
{
    public static readonly LeagueType Professional = new(Guid.Parse("99999999-9999-9999-9999-999999999999"), "PRO", "Professional");
    public static readonly LeagueType Amateur = new(Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "AMT", "Amateur");

    public static IEnumerable<LeagueType> List() => new[] { Professional, Amateur };
}
