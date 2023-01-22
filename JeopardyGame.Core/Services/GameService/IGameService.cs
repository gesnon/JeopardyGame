using JeopardyGame.Core.Models;

namespace JeopardyGame.Core.Services
{
    public interface IGameService
    {
        Task<GameDto> GetByName(string name);

        Task Create(GameDto game);

        Task Remove(string name);

        Task JoinGame(string name);
    }
}