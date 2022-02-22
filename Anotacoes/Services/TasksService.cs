using AN.Api.Model;
using AN.Api.Repositories.Interfaces;
using AN.Api.Services.Interfaces;

namespace AN.Api.Services
{
    public class TasksService : Service<Tasks>, ITasksService
    {
        private readonly ITasksRepository _tasksRepository;
        public TasksService(ITasksRepository tasksRepository) : base(tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }
    }
}
