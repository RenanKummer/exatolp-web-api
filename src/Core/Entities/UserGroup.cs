namespace Ufrgs.ExatoLP.Core.Entities;

public class UserGroup : EntityBase
{
    public required User User { get; set; }
    public required Group Group { get; set; }
}
