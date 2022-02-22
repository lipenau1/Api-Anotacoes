using AN.Api.AppServices.Interfaces;
using AN.Api.DTO.Response;
using AN.Api.Model;
using AN.Api.Services.Interfaces;
using AN.Api.UoW.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;

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

        public Tasks Add(Tasks tasks)
        {
            var tasksAdd = _tasksService.Add(tasks);
            _unitOfWork.Commit();
            return tasksAdd;
        }

        public IEnumerable<TasksResponse> GetAll()
        {
            return _mapper.Map<IEnumerable<TasksResponse>>(_tasksService.GetAll());
        }

        public Tasks GetById(int id)
        {
            return _tasksService.GetById(id);
        }

        public void Remove(Guid id)
        {
            _tasksService.Remove(id);
        }

        public void Update(Tasks tasks)
        {
            _tasksService.Update(tasks);
            _unitOfWork.Commit();
        }
    }
}
