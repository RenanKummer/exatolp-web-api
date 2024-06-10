using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Domain.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class UserGroupEntityConfig : EntityBaseConfig<UserGroup>
{
    public override void Configure(EntityTypeBuilder<UserGroup> builder)
    {
        base.Configure(builder);
        
        builder.ToTable("user_groups");

        builder.HasOne(userGroup => userGroup.User)
            .WithMany()
            .HasForeignKey(UserEntityConfig.PrimaryKeyColumn)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(userGroup => userGroup.Group)
            .WithMany(group => group.Users)
            .HasForeignKey(GroupEntityConfig.PrimaryKeyColumn)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasKey([UserEntityConfig.PrimaryKeyColumn, GroupEntityConfig.PrimaryKeyColumn]);

    }
}
