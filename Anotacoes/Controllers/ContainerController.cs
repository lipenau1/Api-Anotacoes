using AN.Api.AppServices.Interfaces;
using AN.Api.DTO.Request;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AN.Api.Controllers
{
    [Route("container")]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiController]
    public class ContainerController : ControllerBase
    {
        private readonly IContainerAppService _containerAppService;

        public ContainerController(IContainerAppService containerAppService)
        {
            _containerAppService = containerAppService;
        }
        [HttpPost]
        public IActionResult Add(ContainerAddRequest container)
        {
            return Ok(_containerAppService.Add(container));
        }

        [HttpPut]
        public IActionResult Update(ContainerUpdateRequest container)
        {
            return Ok(_containerAppService.Update(container));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_containerAppService.GetAll());
        }

        [HttpGet]
        [Route("board")]
        public IActionResult GetByBoardId(Guid id)
        {
            return Ok(_containerAppService.GetByBoardId(id));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_containerAppService.GetById(id));
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(Guid id)
        {
            _containerAppService.Remove(id);
            return Ok();
        }
    }
}
