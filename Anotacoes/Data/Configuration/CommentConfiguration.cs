using AN.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AN.Api.Data.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(p => p.Description)
                .HasColumnType("VARCHAR(MAX)")
                .IsRequired();
            
            builder.HasOne(p => p.User)
                .WithMany(p => p.Comments)
                .HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Task)
                .WithMany(p => p.Comments)
                .HasForeignKey(p => p.TaskId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
