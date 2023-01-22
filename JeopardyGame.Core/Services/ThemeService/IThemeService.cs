using JeopardyGame.Core.Models;

namespace JeopardyGame.Core.Services.ThemeService
{
    public interface IThemeService
    {
        Task<int> Create(ThemeDto theme);

        Task Update(ThemeDto theme);

        Task Remove(int id);

        Task<ThemeDto> Get(int id);
    }
}
