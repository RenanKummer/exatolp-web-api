namespace Ufrgs.ExatoLP.Core.Entities;

public class FormalDefinition : UpdatableEntity
{
    public string Id { get; set; } = string.Empty;
    public required string Definition {  get; set; }
}
