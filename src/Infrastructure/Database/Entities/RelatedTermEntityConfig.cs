using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;
using Ufrgs.ExatoLP.Infrastructure.Database.Constants;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class RelatedTermEntityConfig : UpdatableEntityConfig<RelatedTerm>
{
    public override void Configure(EntityTypeBuilder<RelatedTerm> builder)
    {
        builder.ToTable("related_terms");

        builder.Property(relatedTerm => relatedTerm.Relationship).HasColumnName("relationship").IsRequired();
        builder.Property(relatedTerm => relatedTerm.IsSymetric).HasColumnName("is_symetric").HasDefaultValue(false);

        builder.HasOne(relatedTerm => relatedTerm.SourceTerm)
            .WithMany()
            .HasForeignKey(PrimaryColumnNames.SourceTermCompositeId)
            .IsRequired();

        builder.HasOne(relatedTerm => relatedTerm.DestinationTerm)
            .WithMany()
            .HasForeignKey(PrimaryColumnNames.DestinationTermCompositeId)
            .IsRequired();

        builder.HasKey([..PrimaryColumnNames.SourceTermCompositeId, ..PrimaryColumnNames.DestinationTermCompositeId]);

        base.Configure(builder);
    }
}
