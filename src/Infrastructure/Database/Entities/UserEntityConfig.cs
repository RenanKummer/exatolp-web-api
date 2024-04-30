using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ufrgs.ExatoLP.Core.Entities;
using Ufrgs.ExatoLP.Infrastructure.Database.Constants;

namespace Ufrgs.ExatoLP.Infrastructure.Database.Entities;

public class UserEntityConfig : UpdatableEntityConfig<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.HasKey(user => user.Id);
        builder.HasIndex(user => user.Email).IsUnique();

        builder.Property(user => user.Id).HasColumnName(PrimaryColumnNames.UserId).ValueGeneratedOnAdd();
        builder.Property(user => user.FullName).HasColumnName("user_full_name").IsRequired();
        builder.Property(user => user.Email).HasColumnName("user_email").IsRequired();

        builder.Ignore(user => user.Groups);

        base.Configure(builder);
    }
}
