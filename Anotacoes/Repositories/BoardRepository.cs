using AN.Api.Data;
using AN.Api.Model;
using AN.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AN.Api.Repositories
{
    public class BoardRepository : Repository<Board>, IBoardRepository
    {
        public BoardRepository(ApplicationContext context) : base(context)
        {
        }

        public override IEnumerable<Board> GetAll()
        {
            return DbSet
                .Include(x => x.Containers)
                .ThenInclude(x => x.Tasks)
                .ThenInclude(x => x.Comments)
                .ToList();
        }

        public IEnumerable<Board> GetByUser(int userId)
        {
            return DbSet
                .Where(x => x.UserId == userId)
                .Include(x => x.Containers)
                .ThenInclude(x => x.Tasks)
                .ThenInclude(x => x.Comments)
                .ToList();
        }

        public Board GetBoardById(Guid id)
        {
            return DbSet
                .Include(x => x.Containers)
                    .ThenInclude(x => x.Tasks)
                .FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Board> Get(Guid? id)
        {
            return DbSet.Where(x => 
                    (!id.HasValue) || (x.Id == id))
                    .Include(x => x.Containers)
                    .ThenInclude(x => x.Tasks)
                    .ThenInclude(x => x.Comments);
        }
    }
}
