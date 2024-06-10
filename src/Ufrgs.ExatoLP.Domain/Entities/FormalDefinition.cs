namespace Ufrgs.ExatoLP.Domain.Entities;

public class FormalDefinition : UpdatableEntity
{
    public string? Id { get; set; }
    public required string Definition {  get; set; }

    public IEnumerable<FormalDefinitionAuthor> FormalDefinitionAuthors { get; set; } = [];
    public IEnumerable<FormalDefinitionResource> FormalDefinitionResources { get; set; } = [];
}
