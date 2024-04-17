namespace Ufrgs.ExatoLP.Core.Entities;

public class Permission : UpdatableEntity
{
    public string Id { get; set; } = string.Empty;
    public required string Name { get; set; }
    public required string Description { get; set; }
}
