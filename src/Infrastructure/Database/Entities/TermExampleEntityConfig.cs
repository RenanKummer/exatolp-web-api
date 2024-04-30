using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using Ufrgs.ExatoLP.Core.Entities;
using Ufrgs.ExatoLP.Infrastructure.Database.Constants;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class TermExampleEntityConfig : UpdatableEntityConfig<TermExample>
{
    public override void Configure(EntityTypeBuilder<TermExample> builder)
    {
        builder.ToTable("term_examples");

        builder.Property(termExample => termExample.Id)
            .HasColumnName(PrimaryColumnNames.ExampleId)
            .ValueGeneratedOnAdd();

        builder.Property(termExample => termExample.ExampleSentence).HasColumnName("example_sentence").IsRequired();

        builder.HasOne(termExample => termExample.Term)
            .WithMany(term => term.Examples)
            .HasForeignKey(PrimaryColumnNames.TermCompositeId)
            .IsRequired();

        builder.HasKey([nameof(TermExample.Id), ..PrimaryColumnNames.TermCompositeId]);

        base.Configure(builder);
    }
}
