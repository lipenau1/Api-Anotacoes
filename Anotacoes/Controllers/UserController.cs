﻿using AN.Api.Services;
using AN.Api.Model;
using Microsoft.AspNetCore.Mvc;
using AN.Api.AppServices.Interfaces;

namespace Anotacoes.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpGet]
        public IActionResult GetUsers() => Ok(_userAppService.ObterTodos());


        [HttpGet("{id}")]
        public IActionResult GetUser(int id) => Ok(_userAppService.ObterPorId(id));

        [HttpPost]
        public IActionResult Post([FromBody] User user) => Ok(_userAppService.Adicionar(user));

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] User user)
        {
            _userAppService.Atualizar(user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userAppService.Remover(id);
            return Ok();
        } 
    }
}

