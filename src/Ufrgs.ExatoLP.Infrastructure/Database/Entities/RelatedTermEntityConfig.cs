using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Domain.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class RelatedTermEntityConfig : UpdatableEntityConfig<RelatedTerm>
{
    public override void Configure(EntityTypeBuilder<RelatedTerm> builder)
    {
        base.Configure(builder);
        
        builder.ToTable("related_terms");

        builder.Property(relatedTerm => relatedTerm.Relationship).HasColumnName("relationship").IsRequired();
        builder.Property(relatedTerm => relatedTerm.IsSymmetric).HasColumnName("is_symmetric").HasDefaultValue(true);

        var sourceTermForeignKeyColumns =
            TermEntityConfig.PrimaryKeyColumns.Select(column => $"source_{column}").ToArray();
        var destinationTermForeignKeyColumns =
            TermEntityConfig.PrimaryKeyColumns.Select(column => $"destination_{column}").ToArray();
        
        builder.HasOne(relatedTerm => relatedTerm.SourceTerm)
            .WithMany()
            .HasForeignKey(sourceTermForeignKeyColumns)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(relatedTerm => relatedTerm.DestinationTerm)
            .WithMany()
            .HasForeignKey(destinationTermForeignKeyColumns)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasKey([..sourceTermForeignKeyColumns, ..destinationTermForeignKeyColumns]);

    }
}
