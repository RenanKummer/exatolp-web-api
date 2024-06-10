namespace Ufrgs.ExatoLP.Domain.Entities;

public abstract class EntityBase
{
    public required User CreatedBy { get; init; }
    public required DateTime CreationDate { get; init; } = DateTime.UtcNow;
}
