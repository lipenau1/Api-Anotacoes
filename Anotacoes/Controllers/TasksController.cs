﻿using AN.Api.AppServices.Interfaces;
using AN.Api.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AN.Api.Controllers
{
    [Route("tasks")]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITasksAppService _tasksAppService;

        public TasksController(ITasksAppService tasksAppService)
        {
            _tasksAppService = tasksAppService;
        }

        [HttpGet]
        public IActionResult GetTaskss() => Ok(_tasksAppService.GetAll());


        [HttpGet("{id}")]
        public IActionResult GetTasks(int id) => Ok(_tasksAppService.GetById(id));

        [HttpPost]
        public IActionResult Post([FromBody] Tasks tasks) => Ok(_tasksAppService.Add(tasks));

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Tasks tasks)
        {
            _tasksAppService.Update(tasks);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _tasksAppService.Remove(id);
            return Ok();
        }
    }
}