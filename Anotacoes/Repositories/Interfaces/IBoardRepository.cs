using AN.Api.Model;
using System;
using System.Collections.Generic;

namespace AN.Api.Repositories.Interfaces
{
    public interface IBoardRepository : IRepository<Board>
    {
        IEnumerable<Board> Get(Guid? id);
        Board GetBoardById(Guid id);
    }
}
