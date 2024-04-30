namespace Ufrgs.ExatoLP.Core.Entities;

public class RelatedTerm : UpdatableEntity
{
    public required Term SourceTerm { get; set; }
    public required Term DestinationTerm { get; set; }
    public required string Relationship { get; set; }
    public bool IsSymetric { get; set; } = true;
}
