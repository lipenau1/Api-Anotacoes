using AN.Api.DTO.Request;
using AN.Api.Model;
using AN.Api.Repositories.Interfaces;
using AN.Api.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace AN.Api.Services
{
    public class BoardService : Service<Board>, IBoardService
    {
        private readonly IBoardRepository _boardRepository;
        public BoardService(IBoardRepository boardRepository) : base(boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public IEnumerable<Board> Get(Guid? id)
        {
            return _boardRepository.Get(id);
        }

        public Board GetBoardById(Guid id)
        {
            return _boardRepository.GetBoardById(id);
        }
    }
}
