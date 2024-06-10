using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Domain.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class GroupPermissionEntityConfig : EntityBaseConfig<GroupPermission>
{
    public override void Configure(EntityTypeBuilder<GroupPermission> builder)
    {
        base.Configure(builder);
        
        builder.ToTable("group_permissions");

        builder.HasOne(groupPermission => groupPermission.Group)
            .WithMany(group => group.Permissions)
            .HasForeignKey(GroupEntityConfig.PrimaryKeyColumn)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(groupPermission => groupPermission.Permission)
            .WithMany()
            .HasForeignKey(PermissionEntityConfig.PrimaryKeyColumn)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasKey([GroupEntityConfig.PrimaryKeyColumn, PermissionEntityConfig.PrimaryKeyColumn]);
    }
}
