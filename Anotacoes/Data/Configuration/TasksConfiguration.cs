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
            builder.Property(p => p.Description).HasColumnType("varchar(max)").IsRequired();
            builder.Property(p => p.Date).HasColumnType("date").IsRequired();

            builder.HasOne(p => p.User).WithMany(p => p.Tasks).HasForeignKey(p => p.UserId);
            
        }
    }
}
