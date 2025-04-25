using Microsoft.EntityFrameworkCore;

namespace TaskManagementAPI;

public class TaskService : ITaskService
{
    private readonly AppDbContext _db;
    public TaskService(AppDbContext db) => _db = db;
    public async Task<TaskComments> AddcommentsByTaskId(TaskComments taskcomments)
    {
        _db.TaskComments.Add(taskcomments);
            await _db.SaveChangesAsync();
        return taskcomments;
    }
    public async Task<TaskItems> CreateTaskAsync(TaskItems task)
    {
        _db.TaskItems.Add(task);
        await _db.SaveChangesAsync();
        return task;
    }

    public async Task<TaskItems?> GetTaskByIdAsync(int id) =>
        await _db.TaskItems.FindAsync(id);

    public async Task<List<TaskItems>> GetTasksByUserIdAsync(int userId) =>
        await _db.TaskItems.Where(t => t.AssignedUserId == userId).ToListAsync();
}