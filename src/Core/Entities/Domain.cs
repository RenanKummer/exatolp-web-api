namespace Ufrgs.ExatoLP.Core.Entities;

public class Domain : UpdatableEntity
{
    public string Id { get; set; } = string.Empty;
    public required string Description { get; set; }
}
