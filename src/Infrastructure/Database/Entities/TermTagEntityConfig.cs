using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;
using Ufrgs.ExatoLP.Infrastructure.Database.Constants;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class TermTagEntityConfig : EntityBaseConfig<TermTag>
{
    public override void Configure(EntityTypeBuilder<TermTag> builder)
    {
        builder.ToTable("term_tags");

        builder.HasOne(termTag => termTag.Term)
            .WithMany(term => term.TermTags)
            .HasForeignKey(PrimaryColumnNames.TermCompositeId)
            .IsRequired();

        builder.HasOne(termTag => termTag.Tag)
            .WithMany(tag => tag.TermTags)
            .HasForeignKey(PrimaryColumnNames.TagId)
            .IsRequired();

        builder.HasKey([..PrimaryColumnNames.TermCompositeId, PrimaryColumnNames.TagId]);

        base.Configure(builder);
    }
}
