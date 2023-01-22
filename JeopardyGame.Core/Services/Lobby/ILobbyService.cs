using JeopardyGame.Core.Models;

namespace JeopardyGame.Core.Services;

public interface ILobbyService
{
    Task CreateAsync(GameDto game);

    Task GetAsync(string name);

    Task JoinAsync(string name);
}
