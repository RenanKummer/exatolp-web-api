namespace Ufrgs.ExatoLP.Domain.Entities;

public class SimplifiedDefinitionAuthor : EntityBase
{
    public required SimplifiedDefinition Definition { get; set; }
    public required Author Author {  get; set; }
}
