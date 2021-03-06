using AN.Api.AppServices.Interfaces;
using AN.Api.Data;
using AN.Api.DTO.Request;
using AN.Api.DTO.Response;
using AN.Api.Model;
using AN.Api.Services.Interfaces;
using AN.Api.UoW.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AN.Api.AppServices
{
    public class BoardAppService : IBoardAppService
    {
        private readonly IBoardService _boardService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ApplicationContext _context;

        public BoardAppService(IBoardService containerService, IUnitOfWork unitOfWork, IMapper mapper, ApplicationContext context)
        {
            _boardService = containerService;
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }

        public Board Add(BoardAddRequest boardAddRequest)
        {
            var board = _boardService.Add(_mapper.Map<Board>(boardAddRequest));
            _unitOfWork.Commit();
            return board;
        }

        public async Task UpdateBoard (UpdateBoardRequest updateBoard)
        {
            int contContainer = 0;
            int contTask = 0;
            foreach (var container in updateBoard.Lanes)
            {
                container.Position = contContainer++;
                foreach (var task in container.Cards)
                {
                    task.Position = contTask++;
                }
            }
            var obj = _mapper.Map<Board>(updateBoard);
            await _boardService.UpdateBoard(updateBoard.Id, obj);
            return;
        }

        public IEnumerable<BoardResponse> GetByUser(int userId)
        {
            var boards = _boardService.GetByUser(userId);
            var boardsMapped = _mapper.Map<IEnumerable<BoardResponse>>(boards);
            foreach (var item in boards)
                boardsMapped.FirstOrDefault(x => x.Id == item.Id).DateCreated = item.DateCreated.ToString("dd/MM/yyyy");
            return boardsMapped;
        }

        public IEnumerable<BoardResponse> Get(Guid? id)
        {
            var boards = _boardService.Get(id);
            var boardsMapped = _mapper.Map<IEnumerable<BoardResponse>>(boards);
            foreach (var item in boards)
                boardsMapped.FirstOrDefault(x => x.Id == item.Id).DateCreated = item.DateCreated.ToString("dd/MM/yyyy");
            return boardsMapped;
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
