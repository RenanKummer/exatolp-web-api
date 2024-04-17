namespace Ufrgs.ExatoLP.Core.Entities;

public class Group : UpdatableEntity
{
    public string Id { get; set; } = string.Empty;
    public required string Name { get; set; }
    public string? Description { get; set; }
}
