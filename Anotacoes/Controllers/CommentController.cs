using AN.Api.AppServices.Interfaces;
using AN.Api.DTO.Request;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AN.Api.Controllers
{
    [Route("comments")]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentAppService _commentAppService;
        public CommentController(ICommentAppService commentAppService)
        {
            _commentAppService = commentAppService;
        }

        [HttpPost]
        public IActionResult Add(CommentAddRequest comment)
        {
            return Ok(_commentAppService.Add(comment));
        }

        [HttpPut]
        public IActionResult Update(CommentUpdateRequest comment)
        {
            return Ok(_commentAppService.Update(comment));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_commentAppService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_commentAppService.GetById(id));
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(Guid id)
        {
            _commentAppService.Remove(id);
            return Ok();
        }

    }
}
