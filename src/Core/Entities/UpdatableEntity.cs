namespace Ufrgs.ExatoLP.Core.Entities;

public abstract class UpdatableEntity : EntityBase
{
    public User? UpdatedBy { get; set; }
    public DateTime? UpdateDate { get; set; }
}
