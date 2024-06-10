namespace Ufrgs.ExatoLP.Domain.Entities;

public class UserGroup : EntityBase
{
    public required User User { get; init; }
    public required Group Group { get; init; }
}
