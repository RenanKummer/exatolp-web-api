namespace Ufrgs.ExatoLP.Domain.Entities;

public class ResourceType : UpdatableEntity
{
    public string? Id { get; set; }
    public required string Name { get; set; }
}
