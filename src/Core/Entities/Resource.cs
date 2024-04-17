namespace Ufrgs.ExatoLP.Core.Entities;

public class Resource : UpdatableEntity
{
    public string Id { get; set; } = string.Empty;
    public required ResourceType Type { get; set; }
}
