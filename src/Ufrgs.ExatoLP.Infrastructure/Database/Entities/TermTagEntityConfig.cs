using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Domain.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class TermTagEntityConfig : EntityBaseConfig<TermTag>
{
    public override void Configure(EntityTypeBuilder<TermTag> builder)
    {
        base.Configure(builder);
        
        builder.ToTable("term_tags");

        builder.HasOne(termTag => termTag.Term)
            .WithMany(term => term.Tags)
            .HasForeignKey(TermEntityConfig.PrimaryKeyColumns)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(termTag => termTag.Tag)
            .WithMany()
            .HasForeignKey(TagEntityConfig.PrimaryKeyColumn)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasKey([..TermEntityConfig.PrimaryKeyColumns, TagEntityConfig.PrimaryKeyColumn]);

    }
}
