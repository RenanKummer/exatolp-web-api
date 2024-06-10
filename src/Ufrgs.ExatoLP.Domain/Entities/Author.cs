namespace Ufrgs.ExatoLP.Domain.Entities;

public class Author : EntityBase
{
    public string? Id { get; set; }
    public required string FullName { get; set; }

    public IEnumerable<FormalDefinitionAuthor> FormalDefinitionAuthors { get; set; } = [];
    public IEnumerable<SimplifiedDefinitionAuthor> SimplifiedDefinitionAuthors { get; set; } = [];
}
