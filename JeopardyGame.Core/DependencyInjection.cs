using JeopardyGame.Core.Services.Lobby;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace JeopardyGame.Core;

public static class DependencyInjection
{
    public static IServiceCollection AddCore(
        this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddScoped<ILobbyService, LobbyService>();

        return services;
    }

}
