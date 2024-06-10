using Ufrgs.ExatoLP.Domain.Constants;

namespace Ufrgs.ExatoLP.Domain.Entities;

public class SimplifiedDefinition : UpdatableEntity
{
    public string? Id { get; set; }
    public required string Definition {  get; set; }
    public DefinitionStatus Status { get; set; } = DefinitionStatus.Pending;
}
