namespace Ufrgs.ExatoLP.Domain.Entities;

public class User : UpdatableEntity
{
    public string? Id { get; init; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required bool IsEnabled { get; set; } = true;
}
