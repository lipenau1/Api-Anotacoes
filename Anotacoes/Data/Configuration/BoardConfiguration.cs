using AN.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AN.Api.Data.Configuration
{
    public class BoardConfiguration : IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(x => x.DateCreated)
                .HasColumnType("DATE")
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.Boards)
                .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.Containers)
                .WithOne(x => x.Board)
                .HasForeignKey(x => x.BoardId);
        }
    }
}
