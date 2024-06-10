using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Domain.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class TermExampleEntityConfig : UpdatableEntityConfig<TermExample>
{
    public override void Configure(EntityTypeBuilder<TermExample> builder)
    {
        base.Configure(builder);
        
        builder.ToTable("term_examples");

        builder.Property(termExample => termExample.Id)
            .HasColumnName("example_id")
            .ValueGeneratedOnAdd();

        builder.Property(termExample => termExample.ExampleSentence).HasColumnName("example_sentence").IsRequired();

        builder.HasOne(termExample => termExample.Term)
            .WithMany(term => term.Examples)
            .HasForeignKey(TermEntityConfig.PrimaryKeyColumns)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasKey([nameof(TermExample.Id), ..TermEntityConfig.PrimaryKeyColumns]);
    }
}
