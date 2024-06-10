namespace Ufrgs.ExatoLP.Domain.Entities;

public class GroupPermission : EntityBase
{
    public required Group Group {  get; set; }
    public required Permission Permission { get; set; }
}
