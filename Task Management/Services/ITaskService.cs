namespace TaskManagementAPI;

public interface ITaskService
{
    Task<TaskItems> CreateTaskAsync(TaskItems task);
    Task<TaskItems?> GetTaskByIdAsync(int id);
    Task<List<TaskItems>> GetTasksByUserIdAsync(int userId);
    Task<TaskComments> AddcommentsByTaskId(TaskComments taskcomments);
}