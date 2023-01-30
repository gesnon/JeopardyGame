using JeopardyGame.Core.Models;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;

namespace JeopardyGame.Core.Hubs;
public class GameHub : Hub
{
    public static ConcurrentDictionary<string, GameDto> Games = new();
}
