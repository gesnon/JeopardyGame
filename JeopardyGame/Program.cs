using JeopardyGame.Core;
using JeopardyGame.Core.Hubs;
using JeopardyGame.Infrastructure;
using JeopardyGame.CustomExceptionMiddleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCore();
builder.Services.AddInfrastructure();
builder.Services.AddCors();


var app = builder.Build();

//app.UseHttpsRedirection();

app.UseMiddleware<ExceptionMiddleware>();

app.UseCors(builder => builder
  .WithOrigins("null")
  .AllowAnyHeader()
  .AllowAnyMethod()
  .AllowCredentials());

app.MapHub<JeopardyHub>("/jeopardyHub");

app.Run();
