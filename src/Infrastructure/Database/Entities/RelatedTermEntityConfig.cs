using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class RelatedTermEntityConfig : UpdatableEntityConfig<RelatedTerm>
{
    public override void Configure(EntityTypeBuilder<RelatedTerm> builder)
    {
        builder.ToTable("related_terms");

        builder.Property(relatedTerm => relatedTerm.Relationship).HasColumnName("relationship").IsRequired();
        builder.Property(relatedTerm => relatedTerm.IsSymetric).HasColumnName("is_symetric").HasDefaultValue(false);

        var sourceTermForeignKey = new[] { "source_term_id", "source_domain_id" };
        var destinationTermForeignKey = new[] { "destination_term_id", "destination_domain_id" };

        builder.HasOne(relatedTerm => relatedTerm.SourceTerm)
            .WithMany()
            .HasForeignKey(sourceTermForeignKey)
            .IsRequired();

        builder.HasOne(relatedTerm => relatedTerm.DestinationTerm)
            .WithMany()
            .HasForeignKey(destinationTermForeignKey)
            .IsRequired();

        builder.HasKey([..sourceTermForeignKey, ..destinationTermForeignKey]);

        base.Configure(builder);
    }
}
