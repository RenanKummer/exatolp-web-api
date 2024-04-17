namespace Ufrgs.ExatoLP.Core.Entities;

public class ResourceType : UpdatableEntity
{
    public string Id { get; set; } = string.Empty;
    public required string Name { get; set; }
}
