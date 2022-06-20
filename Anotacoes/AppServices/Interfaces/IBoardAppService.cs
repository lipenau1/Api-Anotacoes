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
        void UpdateBoard(UpdateBoardRequest updateBoard);
        void Remove(Guid id);
        IEnumerable<BoardResponse> Get(Guid? id);
        BoardResponse GetById(Guid id);
    }
}
