using JeopardyGame.Core.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddSignalR();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors(builder => builder
    .AllowAnyHeader()
    .AllowAnyMethod());

app.MapHub<JeopardyHub>("jeopardyHub");

app.Run();
