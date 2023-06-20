using Microsoft.AspNetCore.Mvc;
using MyTaskManager.Data;
using MyTaskManager.Models;

namespace MyTaskManager.Endpoints;

public static class TaskEndpoints
{
    public static RouteGroupBuilder MapTasksEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/tasks");

        group.MapGet("/", async ([FromServices] ITaskRepository db) =>
        {
            var allTasks = await db.FindAll();
            return allTasks.Any() ? Results.Ok(allTasks) : Results.NotFound();
        }).WithDisplayName("FindAllTasks");

        group.MapGet("/{id}", async ([FromServices] ITaskRepository db, Guid id) =>
        {
            var taskDto = await db.FindById(id);
            return taskDto is not null ? Results.Ok(taskDto) : Results.NotFound();
        })
        .WithName("FindTaskById")
        .WithDisplayName("FindTaskById");

        group.MapPost("/", async ([FromServices] ITaskRepository db, CreateTaskDto taskDto) =>
        {
            Guid resultId = await db.Create(taskDto);

            return Results.CreatedAtRoute("FindTaskById", new { id = resultId }, taskDto);
        }).WithDisplayName("CreateTask");

        group.MapPut("/{id}", async ([FromServices] ITaskRepository db, Guid id, UpdateTaskDto taskDto) =>
        {
            var existingTask = await db.FindById(id);

            if (existingTask is null)
                return Results.NotFound();

            await db.Update(taskDto, id);

            return Results.NoContent();
        }).WithDisplayName("UpdateTask");

        group.MapDelete("/{id}", async ([FromServices] ITaskRepository db, Guid id) =>
        {
            var existingTask = await db.FindById(id);

            if (existingTask is null)
                return Results.NotFound();

            await db.Delete(id);

            return Results.NoContent();
        }).WithDisplayName("DeleteTask");

        return group;
    }
}