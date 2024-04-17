namespace Ufrgs.ExatoLP.Core.Entities;

public class User : UpdatableEntity
{
    public string Id { get; set; } = string.Empty;
    public required string FullName { get; set; }
    public required string Email { get; set; }
}
