using JeopardyGame.Domain.Entities;

namespace JeopardyGame.Core.Services
{
    public interface IGameService
    {
        Task<Game> GetByName(string name);

        Task Create(Game game);

        Task Remove(string name);

        Task JoinGame(string name);
    }
}