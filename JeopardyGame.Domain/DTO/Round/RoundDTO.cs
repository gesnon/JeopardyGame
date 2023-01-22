using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Domain.DTO
{
    public class RoundDTO
    {
        public int Order { get; set; }

        public int Id { get; set; }
        public List<ThemeDTO> Themes { get; set; }
    }
}
