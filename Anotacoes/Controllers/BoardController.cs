using AN.Api.AppServices.Interfaces;
using AN.Api.DTO.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AN.Api.Controllers
{
    [Route("boards")]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly IBoardAppService _boardAppService;

        public BoardController(IBoardAppService boardAppService)
        {
            _boardAppService = boardAppService;
        }

        [HttpPost]
        public IActionResult Add(BoardAddRequest board)
        {
            return Ok(_boardAppService.Add(board));
        }

        [HttpPost]
        [Route("update-board")]
        public async Task<IActionResult> UpdateBoard(UpdateBoardRequest updateBoard)
        {
            await _boardAppService.UpdateBoard(updateBoard);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(BoardUpdateRequest board)
        {
            return Ok(_boardAppService.Update(board));
        }

        [HttpGet]
        [Route("boards-by-user")]
        public IActionResult GetByUser(int userId)
        {
            return Ok(_boardAppService.GetByUser(userId));
        }

        [HttpGet]
        public IActionResult Get(Guid? id)
        {
            return Ok(_boardAppService.Get(id));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_boardAppService.GetById(id));
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(Guid id)
        {
            _boardAppService.Remove(id);
            return Ok();
        }
    }
}
