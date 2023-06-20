using MyTaskManager.Models;
using MyTaskManager.Helpers;
using Microsoft.EntityFrameworkCore;

namespace MyTaskManager.Data;

public class TaskRepository : ITaskRepository
{
    private readonly TaskDbContext _context;

    public TaskRepository(TaskDbContext context)
    {
        _context = context;
    }

    public async Task<List<TaskDto>> FindAll() =>
         await _context.TaskEntities.Select(t => t.AsDto()).ToListAsync();

    public async Task<TaskDto> FindById(Guid id)
    {
        var taskEntity = await _context.TaskEntities.SingleOrDefaultAsync(t => t.Id == id);

        return taskEntity.AsDto();
    }

    public async Task<Guid> Create(CreateTaskDto taskDto)
    {
        var taskEntity = new TaskEntity(Guid.NewGuid(),
                                            taskDto.Title,
                                            taskDto.Description,
                                            taskDto.Complete,
                                            taskDto.DeliveryEstimate);

        await _context.AddAsync(taskEntity);
        await _context.SaveChangesAsync();
        return taskEntity.Id;
    }

    public async Task Update(UpdateTaskDto taskDto, Guid id)
    {
        var taskEntity = await _context.TaskEntities.SingleOrDefaultAsync(t => t.Id == id);
        taskEntity.Title = taskDto.Title;
        taskEntity.Description = taskDto.Title;
        taskEntity.Complete = taskDto.Complete;
        taskEntity.DeliveryEstimate = taskDto.DeliveryEstimate;

        _context.Update(taskEntity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var taskEntity = await _context.TaskEntities.SingleOrDefaultAsync(t => t.Id == id);
        _context.Remove(taskEntity);
        await _context.SaveChangesAsync();
    }
}