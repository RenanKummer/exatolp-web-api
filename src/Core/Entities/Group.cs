namespace Ufrgs.ExatoLP.Core.Entities;

public class Group : UpdatableEntity
{
    public string? Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    public IEnumerable<User> Users { get; set; } = [];
    public IEnumerable<Permission> Permissions { get; set; } = [];
    public IEnumerable<UserGroup> UserGroups { get; set; } = [];
    public IEnumerable<GroupPermission> GroupPermissions { get; set; } = [];
}
