namespace Ufrgs.ExatoLP.Core.Entities;

public class SimplifiedDefinitionResource : EntityBase
{
    public required SimplifiedDefinition Definition { get; set; }
    public required Resource Resource { get; set; }
}
