using AN.Api.Data;
using AN.Api.Model;
using AN.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AN.Api.Repositories
{
    public class ContainerRepository : Repository<Container>, IContainerRepository
    {
        public ContainerRepository(ApplicationContext context) : base(context)
        {
        }

        public override IEnumerable<Container> GetAll()
        {
            return DbSet
                    .Include(x => x.Tasks)
                    .ThenInclude(x => x.Comments);
        }

        public IEnumerable<Container> GetByBoardId(Guid id)
        {
            return DbSet.Where(x => x.BoardId == id).Include(x => x.Tasks);
        }
    }
}
