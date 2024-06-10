using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Domain.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class PermissionEntityConfig : UpdatableEntityConfig<Permission>
{
    public const string PrimaryKeyColumn = "permission_id";
    
    public override void Configure(EntityTypeBuilder<Permission> builder)
    {
        base.Configure(builder);
        
        builder.ToTable("permissions");

        builder.HasKey(permission => permission.Id);
        builder.HasIndex(permission => permission.Name).IsUnique();

        builder.Property(permission => permission.Id)
            .HasColumnName(PrimaryKeyColumn)
            .ValueGeneratedOnAdd();

        builder.Property(permission => permission.Name).HasColumnName("permission_name").IsRequired();
        builder.Property(permission => permission.Description).HasColumnName("permission_description");

    }
}
