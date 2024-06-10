namespace Ufrgs.ExatoLP.Domain.Entities;

public class TermTag : EntityBase
{
    public required Term Term { get; set; }
    public required Tag Tag {  get; set; }
}
