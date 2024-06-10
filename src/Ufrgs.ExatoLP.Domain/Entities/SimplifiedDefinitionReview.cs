using Ufrgs.ExatoLP.Domain.Constants;

namespace Ufrgs.ExatoLP.Domain.Entities;

public class SimplifiedDefinitionReview : UpdatableEntity
{
    public string? Id { get; set; }
    public required SimplifiedDefinition Definition { get; set; }
    public required ReviewStatus Outcome { get; set; }
    public string? Notes { get; set; }
}
