using AN.Api.DTO.Request;
using AN.Api.DTO.Response;
using AN.Api.Model;
using System;
using System.Collections.Generic;

namespace AN.Api.AppServices.Interfaces
{
    public interface ITasksAppService
    {
        TasksAddRequest Add(TasksAddRequest tasks);
        TasksUpdateRequest Update(TasksUpdateRequest tasks);
        void Remove(Guid id);
        IEnumerable<TasksResponse> GetAll();
        TasksResponse GetById(Guid id);
    }
}
