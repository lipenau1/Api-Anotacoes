using AN.Api.Data;
using AN.Api.Model;
using AN.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
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
                .Include(x => x.Containers).ThenInclude(x => x.Tasks).ThenInclude(x => x.Comments).ToList();
        }
    }
}
