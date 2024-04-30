using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;
using Ufrgs.ExatoLP.Infrastructure.Database.Constants;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class UserGroupEntityConfig : EntityBaseConfig<UserGroup>
{
    public override void Configure(EntityTypeBuilder<UserGroup> builder)
    {
        builder.ToTable("user_groups");

        builder.HasOne(userGroup => userGroup.User)
            .WithMany(user => user.UserGroups)
            .HasForeignKey(PrimaryColumnNames.UserId)
            .IsRequired();

        builder.HasOne(userGroup => userGroup.Group)
            .WithMany(group => group.UserGroups)
            .HasForeignKey(PrimaryColumnNames.GroupId)
            .IsRequired();

        builder.HasKey(PrimaryColumnNames.UserId, PrimaryColumnNames.GroupId);

        base.Configure(builder);
    }
}
