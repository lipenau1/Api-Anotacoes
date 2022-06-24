using AN.Api.DTO.Request;
using AN.Api.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AN.Api.Services.Interfaces
{
    public interface IBoardService : IService<Board>
    {
        IEnumerable<Board> Get(Guid? id);
        Task UpdateBoard(Guid boardId, Board newBoard);
        Board GetBoardById(Guid id);
    }
}
