using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class GroupPermissionEntityConfig : EntityBaseConfig<GroupPermission>
{
    public override void Configure(EntityTypeBuilder<GroupPermission> builder)
    {
        builder.ToTable("group_permissions");

        builder.HasOne(groupPermission => groupPermission.Group)
            .WithMany(group => group.GroupPermissions)
            .HasForeignKey("group_id")
            .IsRequired();

        builder.HasOne(groupPermission => groupPermission.Permission)
            .WithMany()
            .HasForeignKey("permission_id")
            .IsRequired();

        builder.HasKey("group_id", "permission_id");

        base.Configure(builder);
    }
}
