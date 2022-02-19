using AN.Api.Data;
using AN.Api.Model;
using AN.Api.Repositories.Interfaces;

namespace AN.Api.Repositories
{
    public class TasksRespository : Repository<Tasks>, ITasksRepository
    {
        public TasksRespository(ApplicationContext context) : base(context)
        {
        }
    }
}
