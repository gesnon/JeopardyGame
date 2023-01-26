using JeopardyGame.Core.Services.Cache;
using Microsoft.Extensions.Caching.Memory;

namespace JeopardyGame.Infrastructure.Cache;

public class InMemoryCache : ICacheService
{
    private readonly IMemoryCache _memoryCache;

    public InMemoryCache(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }

    public Task<string?> GetAsync(string name)
    {
        var value = _memoryCache.Get<string>(name);

        return Task.FromResult(value);
    }

    public Task SetAsync(string name, string value)
    {
        _memoryCache.Set(name, value);

        return Task.CompletedTask;
    }
}
