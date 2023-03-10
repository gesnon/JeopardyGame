using JeopardyGame.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JeopardyGame.Core.Common.Interfaces;

public interface IAppDbContext
{
    public DbSet<Pack> Packs { get; set; }

    public DbSet<Round> Rounds { get; set; }

    public DbSet<Theme> Themes { get; set; }

    public DbSet<Question> Questions { get; set; }

    public DbSet<Player> Players { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
