namespace Ufrgs.ExatoLP.Core.Entities;

public class SimplifiedDefinitionAuthor : EntityBase
{
    public required SimplifiedDefinition Definition { get; set; }
    public required Author Author {  get; set; }
}
