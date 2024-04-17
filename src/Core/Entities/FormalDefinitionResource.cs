namespace Ufrgs.ExatoLP.Core.Entities;

public class FormalDefinitionResource : EntityBase
{
    public required FormalDefinition Definition { get; set; }
    public required Resource Resource { get; set; }
}
