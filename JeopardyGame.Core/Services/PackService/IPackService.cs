using JeopardyGame.Core.Models;

namespace JeopardyGame.Core.Services.PackService
{
    public interface IPackService
    {
        Task<int> CreateAsync(PackDto pack);

        Task UpdateAsync(PackDto pack);

        Task RemoveAsync(int id);

        Task<PackDto> GetAsync(int id);

        Task<List<PackDto>> ListAsync();
    }
}
