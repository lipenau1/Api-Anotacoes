using AN.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AN.Api.Data.Configuration
{
    public class TasksConfiguration : IEntityTypeConfiguration<Tasks>
    {
        public void Configure(EntityTypeBuilder<Tasks> builder)
        {
            builder.ToTable("Tasks");
            builder.HasKey(t => t.Id);

            builder.Property(x => x.Id).IsRequired().ValueGeneratedNever();

            builder.Property(t => t.Title)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("VARCHAR(MAX)");

            builder.Property(x => x.Label)
                .HasColumnType("VARCHAR(100)");

            builder.Property(p => p.DateCreated)
                .HasColumnType("DATE")
                .IsRequired();

            builder.Property(p => p.DateProgress)
                .HasColumnType("DATE")
                .IsRequired();

            builder.Property(p => p.Status)
                .HasColumnType("INT")
                .IsRequired();

            builder.HasMany(p => p.Attachments)
                .WithOne(p => p.Task)
                .HasForeignKey(p => p.TaskId);

            builder.HasMany(p => p.Comments)
                .WithOne(p => p.Task)
                .HasForeignKey(p => p.TaskId);

            builder.Property(x => x.Position)
                .HasColumnType("int")
                .HasDefaultValue(0);
        }
    }
}
