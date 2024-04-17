namespace Ufrgs.ExatoLP.Core.Entities;

public class Tag : UpdatableEntity
{
    public string Id { get; set; } = string.Empty;
    public required string Name { get; set; }
    public string? Description { get; set; }
}
