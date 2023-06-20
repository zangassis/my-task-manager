using MyTaskManager.Models;

namespace MyTaskManager.Data;

public interface ITaskRepository
{
    public Task<List<TaskDto>> FindAll();
    public Task<TaskDto> FindById(Guid id);
    public Task<Guid> Create(CreateTaskDto taskDto);
    public Task Update(UpdateTaskDto taskDto, Guid id);
    public Task Delete(Guid id);
}