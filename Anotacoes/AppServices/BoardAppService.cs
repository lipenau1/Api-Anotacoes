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
    public class BoardAppService : IBoardAppService
    {
        private readonly IBoardService _boardService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BoardAppService(IBoardService containerService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _boardService = containerService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public BoardAddRequest Add(BoardAddRequest boardAddRequest)
        {
            _boardService.Add(_mapper.Map<Board>(boardAddRequest));
            _unitOfWork.Commit();
            return boardAddRequest;
        }

        public IEnumerable<BoardResponse> GetAll()
        {
            return _mapper.Map<IEnumerable<BoardResponse>>(_boardService.GetAll());
        }

        public BoardResponse GetById(Guid id)
        {
            return _mapper.Map<BoardResponse>(_boardService.GetById(id));
        }

        public void Remove(Guid id)
        {
            _boardService.Remove(id);
            _unitOfWork.Commit();
        }

        public BoardUpdateRequest Update(BoardUpdateRequest boardUpdateRequest)
        {
            _boardService.Update(_mapper.Map<Board>(boardUpdateRequest));
            _unitOfWork.Commit();
            return boardUpdateRequest;
        }
    }
}
