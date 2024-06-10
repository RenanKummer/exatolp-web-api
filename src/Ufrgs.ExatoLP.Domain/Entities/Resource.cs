namespace Ufrgs.ExatoLP.Domain.Entities;

public class Resource : UpdatableEntity
{
    public string? Id { get; set; }
    public required string Name { get; set; }
    public required ResourceType Type { get; set; }
}
