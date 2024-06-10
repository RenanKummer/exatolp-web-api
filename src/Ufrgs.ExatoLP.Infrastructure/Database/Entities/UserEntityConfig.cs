using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Domain.Entities;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class UserEntityConfig : UpdatableEntityConfig<User>
{
    public const string PrimaryKeyColumn = "user_id";
    
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);
        
        builder.ToTable("users");

        builder.HasKey(user => user.Id);
        builder.HasIndex(user => user.Email).IsUnique();

        builder.Property(user => user.Id).HasColumnName(PrimaryKeyColumn).ValueGeneratedOnAdd();
        builder.Property(user => user.FullName).HasColumnName("user_full_name").IsRequired();
        builder.Property(user => user.Email).HasColumnName("user_email").IsRequired();
        builder.Property(user => user.IsEnabled).HasColumnName("is_enabled").HasDefaultValue(true);
    }
}
