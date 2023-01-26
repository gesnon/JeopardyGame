using JeopardyGame.Core.Services.Cache;
using JeopardyGame.Infrastructure.Cache;
using Microsoft.Extensions.DependencyInjection;

namespace JeopardyGame.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddMemoryCache();
        services.AddScoped<ICacheService, InMemoryCache>();      
        
        return services;
    }

}
