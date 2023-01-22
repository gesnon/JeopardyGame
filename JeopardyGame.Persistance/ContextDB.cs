using JeopardyGame.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JeopardyGame.Persistance
{
    public class ContextDB: DbContext
    {
        public DbSet<Pack> Packs { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Question> Questions { get; set; }      
    
    }
}