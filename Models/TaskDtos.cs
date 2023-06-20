using System.ComponentModel.DataAnnotations;
namespace MyTaskManager.Models;

public record TaskDto(
    Guid Id,
    string Title,
    string Description,
    bool Complete,
    DateTime DeliveryEstimate
);

public record CreateTaskDto(
   [Required][StringLength(50)] string Title,
   [Required][StringLength(50)] string Description,
    bool Complete,
    DateTime DeliveryEstimate
);

public record UpdateTaskDto(
   [Required][StringLength(50)] string Title,
   [Required][StringLength(50)] string Description,
   [Required] bool Complete,
    DateTime DeliveryEstimate
);