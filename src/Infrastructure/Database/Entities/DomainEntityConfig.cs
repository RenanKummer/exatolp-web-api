using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;
using Ufrgs.ExatoLP.Infrastructure.Database.Constants;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class DomainEntityConfig : UpdatableEntityConfig<Domain>
{
    public override void Configure(EntityTypeBuilder<Domain> builder)
    {
        builder.ToTable("domains");

        builder.HasKey(domain => domain.Id);

        builder.Property(domain => domain.Id).HasColumnName(PrimaryColumnNames.DomainId).ValueGeneratedOnAdd();
        builder.Property(domain => domain.Name).HasColumnName("domain_name").IsRequired();
        builder.Property(domain => domain.Description).HasColumnName("domain_description");

        base.Configure(builder);
    }
}
