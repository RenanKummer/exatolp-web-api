namespace Ufrgs.ExatoLP.Core.Entities;

public class Permission : UpdatableEntity
{
    public string? Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}
