using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Domain.Entities
{
    public class Game
    {        
        public string Name { get; set; }
        public User Host { get; set; }
        public string? Password { get; set; }
        public int MaxPlayers { get; set; }
        public List<User> Players { get; set; }
        public Pack Pack { get; set; }
    }
}
