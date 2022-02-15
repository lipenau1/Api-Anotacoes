using AN.Api.Data.Configuration;
using AN.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace AN.Api.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=AnotacoesApi;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfigurationsFromAssembly(typeof(UsuarioConfiguration).Assembly);
        }
    }
}
