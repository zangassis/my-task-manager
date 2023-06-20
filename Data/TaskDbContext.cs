using Microsoft.EntityFrameworkCore;
using MyTaskManager.Models;

namespace MyTaskManager.Data;

public class TaskDbContext : DbContext
{
    public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
    {
    }

    public DbSet<TaskEntity> TaskEntities { get; set; }
}