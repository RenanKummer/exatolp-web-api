namespace Ufrgs.ExatoLP.Domain.Entities;

public class Tag : UpdatableEntity
{
    public string? Id { get; init; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}
