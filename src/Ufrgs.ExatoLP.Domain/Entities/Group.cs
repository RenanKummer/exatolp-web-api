namespace Ufrgs.ExatoLP.Domain.Entities;

public class Group : UpdatableEntity
{
    public string? Id { get; init; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    public IEnumerable<UserGroup> Users { get; set; } = [];
    public IEnumerable<GroupPermission> Permissions { get; set; } = [];
}
