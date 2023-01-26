using JeopardyGame.Core.Common.Interfaces;
using JeopardyGame.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JeopardyGame.Infrastructure.Persistance
{
    public class ContextDB : DbContext, IAppDbContext
    {
        public DbSet<Pack> Packs { get; set; }

        public DbSet<Round> Rounds { get; set; }

        public DbSet<Theme> Themes { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Player> Players { get; set; }

        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {            
        }
    }
}