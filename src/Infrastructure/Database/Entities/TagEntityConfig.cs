using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;
using Ufrgs.ExatoLP.Infrastructure.Database.Constants;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class TagEntityConfig : UpdatableEntityConfig<Tag>
{
    public override void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.ToTable("tags");

        builder.HasKey(tag => tag.Id);

        builder.Property(tag => tag.Id).HasColumnName(PrimaryColumnNames.TagId).ValueGeneratedOnAdd();
        builder.Property(tag => tag.Name).HasColumnName("tag_name").IsRequired();
        builder.Property(tag => tag.Description).HasColumnName("tag_description");

        base.Configure(builder);
    }
}
