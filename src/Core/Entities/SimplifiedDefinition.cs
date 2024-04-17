using Ufrgs.ExatoLP.Core.Constants;

namespace Ufrgs.ExatoLP.Core.Entities;

public class SimplifiedDefinition : UpdatableEntity
{
    public string Id { get; set; } = string.Empty;
    public required string Definition {  get; set; }
    public DefinitionStatus Status { get; set; } = DefinitionStatus.Pending;
}
