namespace Ufrgs.ExatoLP.Domain.Entities;

public class TermSimplifiedDefinition : EntityBase
{
    public required Term Term {  get; set; }
    public required SimplifiedDefinition Definition { get; set; }
}
