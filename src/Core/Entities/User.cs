namespace Ufrgs.ExatoLP.Core.Entities;

public class User : UpdatableEntity
{
    public string? Id { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }

    public IEnumerable<Group> Groups { get; set; } = [];
    public IEnumerable<UserGroup> UserGroups { get; set; } = [];
}
