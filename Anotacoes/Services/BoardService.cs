using AN.Api.Model;
using AN.Api.Repositories.Interfaces;
using AN.Api.Services.Interfaces;

namespace AN.Api.Services
{
    public class BoardService : Service<Board>, IBoardService
    {
        public BoardService(IBoardRepository boardRepository) : base(boardRepository)
        {
        }
    }
}
