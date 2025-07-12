namespace FutbolTracking.Domain.ValueObjects;

public record Rankin(Guid Id, string Key, string Value)
{
    public static readonly Rankin Top = new(Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "TOP", "Top");
    public static readonly Rankin High = new(Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"), "HIG", "High");
    public static readonly Rankin Medium = new(Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"), "MED", "Medium");
    public static readonly Rankin Low = new(Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), "LOW", "Low");

    public static IEnumerable<Rankin> List() => new[] { Top, High, Medium, Low };
}
