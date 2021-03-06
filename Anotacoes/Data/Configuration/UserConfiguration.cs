using AN.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AN.Api.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(p => p.Email)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.HasIndex(x => x.Email).IsUnique();

            builder.Property(p => p.Password)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();

            builder.HasMany(p => p.Comments)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
        }
    }
    

}
