using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class TermTagEntityConfig : EntityBaseConfig<TermTag>
{
    public override void Configure(EntityTypeBuilder<TermTag> builder)
    {
        builder.ToTable("term_tags");

        var termForeignKey = new[] { "term_id", "domain_id" };
        var tagForeignKey = "tag_id";

        builder.HasOne(termTag => termTag.Term)
            .WithMany(term => term.TermTags)
            .HasForeignKey(termForeignKey)
            .IsRequired();

        builder.HasOne(termTag => termTag.Tag)
            .WithMany(tag => tag.TermTags)
            .HasForeignKey(tagForeignKey)
            .IsRequired();

        builder.HasKey([..termForeignKey, tagForeignKey]);

        base.Configure(builder);
    }
}
