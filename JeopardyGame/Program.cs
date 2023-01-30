using JeopardyGame.Core;
using JeopardyGame.Core.Hubs;
using JeopardyGame.Infrastructure;
using JeopardyGame.CustomExceptionMiddleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddCore();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddCors();


var app = builder.Build();

//app.UseHttpsRedirection();

app.UseMiddleware<ExceptionMiddleware>();

app.UseCors(builder => builder
  .WithOrigins("null", "http://127.0.0.1:5173")
  .AllowAnyHeader()
  .AllowAnyMethod()
  .AllowCredentials());

app.MapHub<LobbyHub>("/lobby");

app.Run();
