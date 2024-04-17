namespace Ufrgs.ExatoLP.Core.Entities;

public class TermResource : EntityBase
{
    public required Term Term { get; set; }
    public required Resource Resource {  get; set; }
}
