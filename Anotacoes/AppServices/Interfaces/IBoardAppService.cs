using AN.Api.DTO.Request;
using AN.Api.DTO.Response;
using System;
using System.Collections.Generic;

namespace AN.Api.AppServices.Interfaces
{
    public interface IBoardAppService
    {
        BoardAddRequest Add(BoardAddRequest boardAddRequest);
        BoardUpdateRequest Update(BoardUpdateRequest boardUpdateRequest);
        void Remove(Guid id);
        IEnumerable<BoardResponse> Get(Guid? id);
        BoardResponse GetById(Guid id);
    }
}
