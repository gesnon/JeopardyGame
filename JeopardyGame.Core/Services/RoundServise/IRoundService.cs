using JeopardyGame.Core.Models;

namespace JeopardyGame.Core.Services.RoundServise
{
    public interface IRoundService
    {
        Task Create(RoundDto round);

        Task Update(RoundDto round);

        Task Remove(int id);

        Task<RoundDto> Get(int id);
    }
}
