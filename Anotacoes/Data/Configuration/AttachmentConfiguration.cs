using AN.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AN.Api.Data.Configuration
{
    public class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.AnexoId).HasColumnType("uniqueidentifier").IsRequired();

            builder.HasOne(p => p.Task).WithMany(p => p.Attachments).HasForeignKey(p => p.TaskId);
        }
    }
}
