using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagementAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    private readonly ITaskService _taskService;
    public TasksController(ITaskService taskService) => _taskService = taskService;

    [HttpPost]
    public async Task<IActionResult> CreateTask(TaskItems task) =>
        Created($"/tasks/{task.Id}", await _taskService.CreateTaskAsync(task));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTask(int id) =>
        await _taskService.GetTaskByIdAsync(id) is TaskItems task ? Ok(task) : NotFound();

    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetTasksByUser(int userId) =>
        Ok(await _taskService.GetTasksByUserIdAsync(userId));

    [HttpPost ("taskcomments")]
    public async Task<IActionResult> AddComment(TaskComments taskComments) =>
        Ok(await _taskService.AddcommentsByTaskId(taskComments));
}