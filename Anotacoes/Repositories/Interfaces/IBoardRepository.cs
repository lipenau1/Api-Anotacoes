using AN.Api.Model;
using System;
using System.Collections.Generic;

namespace AN.Api.Repositories.Interfaces
{
    public interface IBoardRepository : IRepository<Board>
    {
        IEnumerable<Board> Get(Guid? id);
        IEnumerable<Board> GetByUser(int userId);
        Board GetBoardById(Guid id);
    }
}
