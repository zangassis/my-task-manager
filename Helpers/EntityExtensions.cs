using MyTaskManager.Models;

namespace MyTaskManager.Helpers;

public static class EntityExtensions
{
    public static TaskDto AsDto(this TaskEntity taskEntity)
    {
        return new TaskDto(
            taskEntity.Id,
            taskEntity.Title,
            taskEntity.Description,
            taskEntity.Complete,
            taskEntity.DeliveryEstimate
        );
    }
}