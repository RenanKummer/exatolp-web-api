namespace Ufrgs.ExatoLP.Core.Entities;

public class Domain : UpdatableEntity
{
    public string? Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }

    public IEnumerable<Term> Terms { get; set; } = [];
}
