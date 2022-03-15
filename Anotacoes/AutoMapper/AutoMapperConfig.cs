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
                config.CreateMap<TasksAddRequest, Tasks>().ReverseMap();
                config.CreateMap<TasksUpdateRequest, Tasks>().ReverseMap();
                config.CreateMap<CommentAddRequest, Comment>().ReverseMap();
                config.CreateMap<CommentUpdateRequest, Comment>().ReverseMap();
                config.CreateMap<BoardAddRequest, Board>().ReverseMap();
                config.CreateMap<BoardUpdateRequest, Board>().ReverseMap();
                config.CreateMap<ContainerAddRequest, Container>().ReverseMap();
                config.CreateMap<ContainerUpdateRequest, Container>().ReverseMap();

                config.CreateMap<TasksResponse, Tasks>().ReverseMap();
                config.CreateMap<UserResponse, User>().ReverseMap();
                config.CreateMap<CommentResponse, Comment>().ReverseMap();
                config.CreateMap<BoardResponse, Board>().ReverseMap();
                config.CreateMap<ContainerResponse, Container>().ReverseMap();
            });
            var mapper = mapperConfig.CreateMapper();
            service.AddSingleton(mapper);
        }
    }
}
