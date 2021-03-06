using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Api.Repositories;
using TodoList.Models;
using TodoList.Models.Enums;

namespace TodoList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        public TasksController (ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        //api/tasks?name=
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] TaskListSearch taskListSearch)
        {
            var tasks = await _taskRepository.GetTaskList(taskListSearch);
            var taskDtos = tasks.Select(x => new TaskDto()
            {
                Status = x.Status,
                Name = x.Name,
                AssigneeId = x.AssigneeId,
                CreatedDate = x.CreateDate,
                Priority = x.Priority,
                Id = x.Id,
                AssigneeName = x.Assignee!=null? x.Assignee.FirstName + ' ' + x.Assignee.LastName:"N/A"
            });
            return Ok(taskDtos);
        }
        ///
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]TaskCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var task = await _taskRepository.Create(new Entities.Task()
            {
                Name = request.Name,
                Priority = request.Priority.HasValue ? request.Priority.Value : Priority.Low,
                Status = Status.Open,
                CreateDate = DateTime.Now,
                Id = request.Id

            });
            return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
        }
        ///
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(Guid id,[FromBody] TaskUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var taskFromDb = await _taskRepository.GetById(id);

            if (taskFromDb == null)
            {
                return NotFound($"{id} is not found");
            }

            taskFromDb.Name = request.Name;
            taskFromDb.Priority = request.Priority;
            var taskResult = await _taskRepository.Update(taskFromDb);

            return Ok(new TaskDto()
            {
                Name = taskResult.Name,
                AssigneeId = taskResult.AssigneeId,
                CreatedDate = taskResult.CreateDate,
                Priority = taskResult.Priority,
                Id = taskResult.Id,
            });
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var task = await _taskRepository.GetById(id);
            if (task == null) return NotFound($"{id} is not found");
            return Ok(new TaskDto()
                {
                Name = task.Name,
                AssigneeId = task.AssigneeId,
                CreatedDate = task.CreateDate,
                Priority = task.Priority,
                Id = task.Id,
            });
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var task = await _taskRepository.GetById(id);
            if (task == null) return NotFound($"{id} is not found");

            await _taskRepository.Delete(task);
            return Ok(new TaskDto()
            {
                Name = task.Name,
                AssigneeId = task.AssigneeId,
                CreatedDate = task.CreateDate,
                Priority = task.Priority,
                Id = task.Id,
            });
        }
    }
}

