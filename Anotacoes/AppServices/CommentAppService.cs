using AN.Api.AppServices.Interfaces;
using AN.Api.DTO.Request;
using AN.Api.DTO.Response;
using AN.Api.Model;
using AN.Api.Services.Interfaces;
using AN.Api.UoW.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace AN.Api.AppServices
{
    public class CommentAppService : ICommentAppService
    {
        private readonly ICommentService _commentService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CommentAppService(ICommentService commentService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _commentService = commentService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public CommentAddRequest Add(CommentAddRequest comment)
        {
            _commentService.Add(_mapper.Map<Comment>(comment));
            _unitOfWork.Commit();
            return comment;
        }

        public IEnumerable<CommentResponse> GetAll()
        {
            return _mapper.Map<IEnumerable<CommentResponse>>(_commentService.GetAll());
        }

        public CommentResponse GetById(Guid id)
        {
            return _mapper.Map<CommentResponse>(_commentService.GetById(id));
        }

        public void Remove(Guid id)
        {
            _commentService.Remove(id);
            _unitOfWork.Commit();
        }

        public CommentUpdateRequest Update(CommentUpdateRequest comment)
        {
            _commentService.Update(_mapper.Map<Comment>(comment));
            _unitOfWork.Commit();
            return comment;
        }
    }
}
