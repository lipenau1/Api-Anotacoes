using AN.Api.AppServices.Interfaces;
using AN.Api.DTO.Request;
using AN.Api.DTO.Response;
using AN.Api.Model;
using AN.Api.Services.Interfaces;
using AN.Api.UoW.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AN.Api.AppServices
{
    public class TasksAppService : ITasksAppService
    {

        private readonly ITasksService _tasksService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TasksAppService(ITasksService tasksService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _tasksService = tasksService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public TasksAddRequest Add(TasksAddRequest tasks)
        {
            tasks.Position = _tasksService.GetAll().ToList().Count;
            if (tasks.Label == null)
            {
                tasks.Label = "";
            }
            if (tasks.Description == null)
            {
                tasks.Description = "";
            }
            _tasksService.Add(_mapper.Map<Tasks>(tasks));
            _unitOfWork.Commit();
            return tasks;
        }

        public IEnumerable<TasksResponse> GetAll()
        {
            return _mapper.Map<IEnumerable<TasksResponse>>(_tasksService.GetAll());
        }

        public TasksResponse GetById(Guid id)
        {
            return _mapper.Map<TasksResponse>(_tasksService.GetById(id));
        }

        public void Remove(Guid id)
        {
            _tasksService.Remove(id);
            _unitOfWork.Commit();
        }

        public TasksUpdateRequest Update(TasksUpdateRequest tasks)
        {
            _tasksService.Update(_mapper.Map<Tasks>(tasks));
            _unitOfWork.Commit();
            return tasks;
        }
    }
}
