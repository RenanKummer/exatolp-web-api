using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class UserGroupEntityConfig : EntityBaseConfig<UserGroup>
{
    public override void Configure(EntityTypeBuilder<UserGroup> builder)
    {
        builder.ToTable("user_groups");

        builder.HasOne(userGroup => userGroup.User)
            .WithMany(user => user.UserGroups)
            .HasForeignKey("user_id")
            .IsRequired();

        builder.HasOne(userGroup => userGroup.Group)
            .WithMany(group => group.UserGroups)
            .HasForeignKey("group_id")
            .IsRequired();

        builder.HasKey("user_id", "group_id");

        base.Configure(builder);
    }
}
