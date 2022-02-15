using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace AN.Api.Data
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            try
            {
                using (var scope = host.Services.CreateScope())
                {
                    var appContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                    appContext.Database.Migrate();
                }
                return host;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
