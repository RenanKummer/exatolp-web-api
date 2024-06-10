namespace Ufrgs.ExatoLP.Domain.Entities;

public class RelatedTerm : UpdatableEntity
{
    public required Term SourceTerm { get; set; }
    public required Term DestinationTerm { get; set; }
    public required string Relationship { get; set; }
    public bool IsSymmetric { get; set; } = true;
}
