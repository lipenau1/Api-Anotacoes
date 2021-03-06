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
using AN.Api.Services.Interfaces;
using AN.Api.AutoMapper;

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
            services.AddScoped<ITasksRepository, TasksRepository>();
            services.AddScoped<IAttachmentRepository, AttachmentRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IContainerRepository, ContainerRepository>();
            services.AddScoped<IBoardRepository, BoardRepository>();
            #endregion
            #region SERVICES
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITasksService, TasksService>();
            services.AddScoped<IAttachmentService, AttachmentService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IContainerService, ContainerService>();
            services.AddScoped<IBoardService, BoardService>();
            #endregion
            #region APPSERVICES
            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<ITasksAppService, TasksAppService>();
            services.AddScoped<IAttachmentAppService, AttachmentAppService>();
            services.AddScoped<ICommentAppService, CommentAppService>();
            services.AddScoped<IContainerAppService, ContainerAppService>();
            services.AddScoped<IBoardAppService, BoardAppService>();
            #endregion


            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString));
            new AutoMapperConfig(services);

        }
    }
}
