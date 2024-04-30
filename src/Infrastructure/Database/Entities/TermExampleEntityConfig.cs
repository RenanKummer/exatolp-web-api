using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using Ufrgs.ExatoLP.Core.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class TermExampleEntityConfig : UpdatableEntityConfig<TermExample>
{
    public override void Configure(EntityTypeBuilder<TermExample> builder)
    {
        builder.ToTable("term_examples");

        builder.Property(termExample => termExample.Id).HasColumnName("example_id").ValueGeneratedOnAdd();
        builder.Property(termExample => termExample.ExampleSentence).HasColumnName("example_sentence").IsRequired();

        var termForeignKey = new[] { "term_id", "domain_id" };

        builder.HasOne(termExample => termExample.Term)
            .WithMany(term => term.Examples)
            .HasForeignKey(termForeignKey)
            .IsRequired();

        builder.HasKey([nameof(TermExample.Id), ..termForeignKey]);

        base.Configure(builder);
    }
}
