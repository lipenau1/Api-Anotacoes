using AN.Api.Data.Configuration;
using AN.Api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace AN.Api.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() { }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Container> Containers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new UserConfiguration());
            modelbuilder.ApplyConfiguration(new TasksConfiguration());
            modelbuilder.ApplyConfiguration(new AttachmentConfiguration());
            modelbuilder.ApplyConfiguration(new CommentConfiguration());
            modelbuilder.ApplyConfiguration(new BoardConfiguration());
            modelbuilder.ApplyConfiguration(new ContainerConfiguration());
        }
    }
}
