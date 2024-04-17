namespace Ufrgs.ExatoLP.Core.Entities;

public class TagResource : EntityBase
{
    public required Tag Tag {  get; set; }
    public required Resource Resource {  get; set; }
}
