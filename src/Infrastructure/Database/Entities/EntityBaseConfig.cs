using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public abstract class EntityBaseConfig<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : EntityBase
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.Property(entity => entity.CreationDate).HasColumnName("creation_date").IsRequired();

        builder.HasOne(entity  => entity.CreatedBy)
            .WithMany()
            .HasForeignKey("created_by")
            .OnDelete(DeleteBehavior.SetNull);
    }
}
