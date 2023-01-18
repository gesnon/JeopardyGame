using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Domain.Entities
{
    public class User
    {
        public string Name { get; set; }
        public Role Role { get; set; }
        public int Score { get; set; }
        public int Id { get; set; }
    }
}
