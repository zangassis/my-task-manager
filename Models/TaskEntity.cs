namespace MyTaskManager.Models;

public class TaskEntity
{
    public TaskEntity() { }

    public TaskEntity(Guid id, string? title, string? description, bool complete, DateTime deliveryEstimate)
    {
        Id = id;
        Title = title;
        Description = description;
        Complete = complete;
        DeliveryEstimate = deliveryEstimate;
    }

    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool Complete { get; set; }
    public DateTime DeliveryEstimate { get; set; }
}