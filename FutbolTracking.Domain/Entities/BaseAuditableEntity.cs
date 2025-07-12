namespace FutbolTracking.Domain.Entities;

public abstract class BaseAuditableEntity
{
    public Guid Id { get; set; }
    public bool IsEnabled { get; set; } = true;
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
}
