namespace Ufrgs.ExatoLP.Core.Entities;

public class TermTag : EntityBase
{
    public required Term Term { get; set; }
    public required Tag Tag {  get; set; }
}
