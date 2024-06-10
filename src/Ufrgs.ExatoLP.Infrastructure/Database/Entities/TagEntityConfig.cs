using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Domain.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class TagEntityConfig : UpdatableEntityConfig<Tag>
{
    public const string PrimaryKeyColumn = "tag_id";
    
    public override void Configure(EntityTypeBuilder<Tag> builder)
    {
        base.Configure(builder);
        
        builder.ToTable("tags");

        builder.HasKey(tag => tag.Id);

        builder.Property(tag => tag.Id).HasColumnName(PrimaryKeyColumn).ValueGeneratedOnAdd();
        builder.Property(tag => tag.Name).HasColumnName("tag_name").IsRequired();
        builder.Property(tag => tag.Description).HasColumnName("tag_description");

    }
}
