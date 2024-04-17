namespace Ufrgs.ExatoLP.Core.Entities;

public class FormalDefinitionAuthor : EntityBase
{
    public required FormalDefinition Definition { get; set; }
    public required Author Author {  get; set; }
}
