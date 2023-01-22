using AutoMapper;
using JeopardyGame.Core.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddSignalR();
builder.Services.AddAutoMapper(typeof(MapperConfiguration).Assembly);

var app = builder.Build();

//app.UseHttpsRedirection();

app.UseCors(builder => builder
  .WithOrigins("null")
  .AllowAnyHeader()
  .AllowAnyMethod()
  .AllowCredentials());

app.MapHub<JeopardyHub>("/jeopardyHub");

app.Run();
