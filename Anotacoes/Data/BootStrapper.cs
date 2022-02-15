using AN.Api.AppServices;
using AN.Api.AppServices.Interfaces;
using AN.Api.Repositories;
using AN.Api.Repositories.Interfaces;
using AN.Api.Services;
using AN.Api.UoW.Interfaces;
using AN.Api.UoW;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AN.Api.Data
{
    public static class BootStrapper
    {
        public static void RegisterServices(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<DbConfig>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddHttpContextAccessor();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            #region REPOSITORIES
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion
            #region SERVICES
            services.AddScoped<IUserService, UserService>();
            #endregion
            #region APPSERVICES
            services.AddScoped<IUserAppService, UserAppService>();
            #endregion


            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
