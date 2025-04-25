using Microsoft.EntityFrameworkCore;

namespace TaskManagementAPI;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Users> Users => Set<Users>();
    public DbSet<TaskItems> TaskItems => Set<TaskItems>();
    public DbSet<TaskComments> TaskComments => Set<TaskComments>();
}
