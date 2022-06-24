using AN.Api.DTO.Request;
using AN.Api.DTO.Response;
using AN.Api.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AN.Api.AppServices.Interfaces
{
    public interface IBoardAppService
    {
        Board Add(BoardAddRequest boardAddRequest);
        BoardUpdateRequest Update(BoardUpdateRequest boardUpdateRequest);
        Task UpdateBoard(UpdateBoardRequest updateBoard);
        IEnumerable<BoardResponse> GetByUser(int userId);
        void Remove(Guid id);
        IEnumerable<BoardResponse> Get(Guid? id);
        BoardResponse GetById(Guid id);
    }
}
