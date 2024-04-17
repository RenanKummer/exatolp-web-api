namespace Ufrgs.ExatoLP.Core.Entities;

public abstract class EntityBase
{
    public required User CreatedBy { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
}
