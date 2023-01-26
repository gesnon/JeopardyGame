using JeopardyGame.Core.Services.Cache;
using JeopardyGame.Infrastructure.Cache;
using JeopardyGame.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JeopardyGame.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMemoryCache();
        services.AddDbContext<ContextDB>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("JeopardyDb")));
        services.AddScoped<ICacheService, InMemoryCache>();      
        
        return services;
    }

}
