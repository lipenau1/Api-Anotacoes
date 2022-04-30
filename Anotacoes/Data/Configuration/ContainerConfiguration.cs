using AN.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AN.Api.Data.Configuration
{
    public class ContainerConfiguration : IEntityTypeConfiguration<Container>
    {
        public void Configure(EntityTypeBuilder<Container> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(x => x.Label)
                .HasColumnType("VARCHAR(100)");

            builder.HasOne(x => x.Board)
                .WithMany(x => x.Containers)
                .HasForeignKey(x => x.BoardId);

            builder.HasMany(x => x.Tasks)
                .WithOne(x => x.Container)
                .HasForeignKey(x => x.ContainerId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
