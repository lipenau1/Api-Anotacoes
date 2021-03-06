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

                //update everything
                config.CreateMap<CardRequest, Tasks>()
                    .ForMember(x => x.ContainerId, a => a.MapFrom(c => c.LaneId));
                config.CreateMap<LanesRequest, Container>()
                    .ForMember(x => x.Tasks, a => a.MapFrom(c => c.Cards));
                config.CreateMap<UpdateBoardRequest, Board>()
                    .ForMember(x => x.Containers, a => a.MapFrom(c => c.Lanes))
                    .ForMember(x => x.Id, a => a.Ignore());

                config.CreateMap<TasksResponse, Tasks>().ReverseMap();
                config.CreateMap<UserResponse, User>().ReverseMap();
                config.CreateMap<CommentResponse, Comment>().ReverseMap();
                config.CreateMap<BoardResponse, Board>().ReverseMap();
                config.CreateMap<ContainerResponse, Container>()
                .ForMember(x => x.Tasks, a => a.MapFrom(c => c.Cards))
                .ReverseMap();
            });
            var mapper = mapperConfig.CreateMapper();
            service.AddSingleton(mapper);
        }
    }
}
