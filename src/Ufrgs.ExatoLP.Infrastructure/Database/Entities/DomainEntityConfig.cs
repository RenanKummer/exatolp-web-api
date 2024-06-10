using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class DomainEntityConfig : UpdatableEntityConfig<Domain.Entities.Domain>
{
    public const string PrimaryKeyColumn = "domain_id";
    
    public override void Configure(EntityTypeBuilder<Domain.Entities.Domain> builder)
    {
        base.Configure(builder);

        builder.ToTable("domains");

        builder.HasKey(domain => domain.Id);

        builder.Property(domain => domain.Id).HasColumnName(PrimaryKeyColumn).ValueGeneratedOnAdd();
        builder.Property(domain => domain.Name).HasColumnName("domain_name").IsRequired();
        builder.Property(domain => domain.Description).HasColumnName("domain_description");

    }
}
