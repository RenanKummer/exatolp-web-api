using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Domain.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class TermEntityConfig : UpdatableEntityConfig<Term>
{
    public static readonly string[] PrimaryKeyColumns = ["term_id", DomainEntityConfig.PrimaryKeyColumn];
    
    public override void Configure(EntityTypeBuilder<Term> builder)
    {
        base.Configure(builder);
        
        builder.ToTable("terms");

        builder.Property(term => term.Id).HasColumnName(PrimaryKeyColumns[0]).ValueGeneratedOnAdd();
        builder.Property(term => term.Name).HasColumnName("term_name").IsRequired();
        builder.Property(term => term.GrammarNumber).HasColumnName("grammar_number");
        builder.Property(term => term.GrammarGender).HasColumnName("grammar_gender");
        builder.Property(term => term.GrammarCategory).HasColumnName("grammar_category");
        builder.Property(term => term.IsAbbreviation).HasColumnName("is_abbreviation").HasDefaultValue(false);
        builder.Property(term => term.IsAcronym).HasColumnName("is_acronym").HasDefaultValue(false);

        builder.HasOne(term => term.Domain)
            .WithMany()
            .HasForeignKey(DomainEntityConfig.PrimaryKeyColumn)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasKey(nameof(Term.Id), PrimaryKeyColumns[1]);
    }
}
