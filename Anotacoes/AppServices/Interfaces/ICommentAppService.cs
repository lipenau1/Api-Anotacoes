using AN.Api.DTO.Request;
using AN.Api.DTO.Response;
using System;
using System.Collections.Generic;

namespace AN.Api.AppServices.Interfaces
{
    public interface ICommentAppService
    {
        CommentAddRequest Add(CommentAddRequest comment);
        CommentUpdateRequest Update(CommentUpdateRequest comment);
        void Remove(Guid id);
        IEnumerable<CommentResponse> GetAll();
        CommentResponse GetById(Guid id);
    }
}
