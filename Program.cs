using Microsoft.EntityFrameworkCore;
using MyTaskManager.Data;
using MyTaskManager.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<TaskDbContext>(x => x.UseSqlite(connectionString));

var app = builder.Build();
app.MapTasksEndpoints();
app.Run();