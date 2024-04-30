using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;
using Ufrgs.ExatoLP.Infrastructure.Database.Constants;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class TermEntityConfig : UpdatableEntityConfig<Term>
{
    public override void Configure(EntityTypeBuilder<Term> builder)
    {
        builder.ToTable("terms");

        builder.Property(term => term.Id).HasColumnName(PrimaryColumnNames.TermId).ValueGeneratedOnAdd();
        builder.Property(term => term.Name).HasColumnName("term_name").IsRequired();
        builder.Property(term => term.GrammarNumber).HasColumnName("grammar_number");
        builder.Property(term => term.GrammarGender).HasColumnName("grammar_gender");
        builder.Property(term => term.GrammarCategory).HasColumnName("grammar_category");
        builder.Property(term => term.IsAbbreviation).HasColumnName("is_abbreviation").HasDefaultValue(false);
        builder.Property(term => term.IsAcronym).HasColumnName("is_acronym").HasDefaultValue(false);

        builder.HasOne(term => term.Domain)
            .WithMany(domain => domain.Terms)
            .HasForeignKey(PrimaryColumnNames.DomainId)
            .IsRequired();

        builder.HasKey(nameof(Term.Id), PrimaryColumnNames.DomainId);

        base.Configure(builder);
    }
}
