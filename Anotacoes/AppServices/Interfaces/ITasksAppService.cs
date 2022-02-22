using AN.Api.DTO.Response;
using AN.Api.Model;
using System;
using System.Collections.Generic;

namespace AN.Api.AppServices.Interfaces
{
    public interface ITasksAppService
    {
        Tasks Add(Tasks tasks);
        void Update(Tasks tasks);
        void Remove(Guid id);
        IEnumerable<TasksResponse> GetAll();
        Tasks GetById(int id);
    }
}
