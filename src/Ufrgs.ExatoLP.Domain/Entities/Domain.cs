namespace Ufrgs.ExatoLP.Domain.Entities;

public class Domain : UpdatableEntity
{
    public string? Id { get; init; }
    public required string Name { get; set; }
    public required string Description { get; set; }
}
