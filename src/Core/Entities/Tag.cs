namespace Ufrgs.ExatoLP.Core.Entities;

public class Tag : UpdatableEntity
{
    public string? Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    public IEnumerable<TermTag> TermTags { get; set; } = [];
}
