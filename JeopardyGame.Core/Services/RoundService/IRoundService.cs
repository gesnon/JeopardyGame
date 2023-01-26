using JeopardyGame.Core.Models;

namespace JeopardyGame.Core.Services.RoundService
{
    public interface IRoundService
    {
        Task<int> Create(RoundDto round);

        Task Update(RoundDto round);

        Task Remove(int id);

        Task<RoundDto> Get(int id);
    }
}
