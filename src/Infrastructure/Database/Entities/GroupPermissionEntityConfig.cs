using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;
using Ufrgs.ExatoLP.Infrastructure.Database.Constants;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class GroupPermissionEntityConfig : EntityBaseConfig<GroupPermission>
{
    public override void Configure(EntityTypeBuilder<GroupPermission> builder)
    {
        builder.ToTable("group_permissions");

        builder.HasOne(groupPermission => groupPermission.Group)
            .WithMany(group => group.GroupPermissions)
            .HasForeignKey(PrimaryColumnNames.GroupId)
            .IsRequired();

        builder.HasOne(groupPermission => groupPermission.Permission)
            .WithMany()
            .HasForeignKey(PrimaryColumnNames.PermissionId)
            .IsRequired();

        builder.HasKey(PrimaryColumnNames.GroupId, PrimaryColumnNames.PermissionId);

        base.Configure(builder);
    }
}
