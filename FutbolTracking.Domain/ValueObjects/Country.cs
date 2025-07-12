namespace FutbolTracking.Domain.ValueObjects;

public record Country(Guid Id, string Key, string Value)
{
    public static readonly Country Spain = new(Guid.Parse("11111111-1111-1111-1111-111111111111"), "ESP", "Spain");
    public static readonly Country Italy = new(Guid.Parse("22222222-2222-2222-2222-222222222222"), "ITA", "Italy");
    public static readonly Country England = new(Guid.Parse("33333333-3333-3333-3333-333333333333"), "ENG", "England");
    public static readonly Country France = new(Guid.Parse("44444444-4444-4444-4444-444444444444"), "FRA", "France");
    public static readonly Country Portugal = new(Guid.Parse("55555555-5555-5555-5555-555555555555"), "POR", "Portugal");
    public static readonly Country Netherlands = new(Guid.Parse("66666666-6666-6666-6666-666666666666"), "NED", "Netherlands");
    public static readonly Country Argentina = new(Guid.Parse("77777777-7777-7777-7777-777777777777"), "ARG", "Argentina");
    public static readonly Country Brazil = new(Guid.Parse("88888888-8888-8888-8888-888888888888"), "BRA", "Brazil");

    public static IEnumerable<Country> List() => new[] { Spain, Italy, England, France, Portugal, Netherlands, Argentina, Brazil };
}
