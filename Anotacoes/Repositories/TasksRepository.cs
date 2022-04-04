using AN.Api.Data;
using AN.Api.Model;
using AN.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AN.Api.Repositories
{
    public class TasksRepository : Repository<Tasks>, ITasksRepository
    {
        public TasksRepository(ApplicationContext context) : base(context)
        {
        }

        public override IEnumerable<Tasks> GetAll()
        {
            return DbSet
                .Include(x => x.User)
                .Include(x => x.Comments);
        }
    }
}
