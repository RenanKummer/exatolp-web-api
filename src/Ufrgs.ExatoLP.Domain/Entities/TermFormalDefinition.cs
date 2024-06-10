namespace Ufrgs.ExatoLP.Domain.Entities;

public class TermFormalDefinition : EntityBase
{
    public required Term Term { get; set; }
    public required FormalDefinition Definition { get; set; }
}
