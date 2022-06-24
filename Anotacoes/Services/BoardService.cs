using AN.Api.DTO.Request;
using AN.Api.Model;
using AN.Api.Repositories.Interfaces;
using AN.Api.Services.Interfaces;
using AN.Api.UoW.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AN.Api.Services
{
    public class BoardService : Service<Board>, IBoardService
    {
        private readonly IBoardRepository _boardRepository;
        private readonly IUnitOfWork _unitOfWork;
        public BoardService(IBoardRepository boardRepository, IUnitOfWork unitOfWork) : base(boardRepository)
        {
            _boardRepository = boardRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Board> Get(Guid? id)
        {
            return _boardRepository.Get(id);
        }

        public async Task UpdateBoard(Guid boardId, Board newBoard)
        {
            var oldBoard = _boardRepository.GetBoardById(boardId);
            oldBoard.Update(newBoard);
            await _unitOfWork.CommitAsync();
        }

        public Board GetBoardById(Guid id)
        {
            return _boardRepository.GetBoardById(id);
        }
    }
}
