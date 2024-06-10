using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Domain.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class GroupEntityConfig : UpdatableEntityConfig<Group>
{
    public const string PrimaryKeyColumn = "group_id";
    
    public override void Configure(EntityTypeBuilder<Group> builder)
    {
        base.Configure(builder);
        
        builder.ToTable("groups");

        builder.HasKey(group => group.Id);
        builder.HasIndex(group => group.Name).IsUnique();

        builder.Property(group => group.Id).HasColumnName(PrimaryKeyColumn).ValueGeneratedOnAdd();
        builder.Property(group => group.Name).HasColumnName("group_name").IsRequired();
        builder.Property(group => group.Description).HasColumnName("group_description");

    }
}
