using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;
using Ufrgs.ExatoLP.Infrastructure.Database.Constants;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class GroupEntityConfig : UpdatableEntityConfig<Group>
{
    public override void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.ToTable("groups");

        builder.HasKey(group => group.Id);
        builder.HasIndex(group => group.Name).IsUnique();

        builder.Property(group => group.Id).HasColumnName(PrimaryColumnNames.GroupId).ValueGeneratedOnAdd();
        builder.Property(group => group.Name).HasColumnName("group_name").IsRequired();
        builder.Property(group => group.Description).HasColumnName("group_description");

        base.Configure(builder);
    }
}
