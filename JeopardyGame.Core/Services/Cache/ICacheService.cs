namespace JeopardyGame.Core.Services.Cache;

public interface ICacheService
{
    Task<string?> GetAsync(string name);

    Task SetAsync(string name, string value);
}
