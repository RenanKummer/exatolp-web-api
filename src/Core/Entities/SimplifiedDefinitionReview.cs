using Ufrgs.ExatoLP.Core.Constants;

namespace Ufrgs.ExatoLP.Core.Entities;

public class SimplifiedDefinitionReview : UpdatableEntity
{
    public string Id { get; set; } = string.Empty;
    public required SimplifiedDefinition Definition { get; set; }
    public required ReviewStatus Outcome { get; set; }
    public string? Notes { get; set; }
}
