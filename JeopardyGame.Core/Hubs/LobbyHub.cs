using JeopardyGame.Core.Models;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;

namespace JeopardyGame.Core.Hubs;

public class LobbyHub : Hub
{
    public static ConcurrentDictionary<string, UserDto> Users = new();

    public void Login(UserDto userDto)
    {
        Users.TryAdd(this.Context.ConnectionId, userDto);
    }

    public async Task CreateLobby(GameDto gameDto)
    {
        await this.Groups.AddToGroupAsync(this.Context.ConnectionId, gameDto.Name);
        gameDto.Players.Add(Users[this.Context.ConnectionId]);
        GameHub.Games.TryAdd(gameDto.Name, gameDto);
    }

    public async Task JoinGame(string name)
    {
        var user = Users[this.Context.ConnectionId];
        await this.Groups.AddToGroupAsync(this.Context.ConnectionId, name);
        GameHub.Games[name].Players.Add(user);
        await this.Clients.Group(name).SendAsync("PlayerJoined", $"{user.Name} joined the game");
    }
}
