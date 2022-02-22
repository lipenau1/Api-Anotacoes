using AN.Api.DTO.Request;
using AN.Api.DTO.Response;
using AN.Api.Model;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace AN.Api.AutoMapper
{
    public class AutoMapperConfig
    {
        public AutoMapperConfig(IServiceCollection service)
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<UserAddRequest, User>().ReverseMap();
                config.CreateMap<UserUpdateRequest, User>().ReverseMap();
                config.CreateMap<TasksAddRequest, User>().ReverseMap();
                config.CreateMap<TasksUpdateRequest, User>().ReverseMap();

                config.CreateMap<TasksResponse, Tasks>().ReverseMap();
                config.CreateMap<UserResponse, User>().ReverseMap();
            });
            var mapper = mapperConfig.CreateMapper();
            service.AddSingleton(mapper);
        }
    }
}
