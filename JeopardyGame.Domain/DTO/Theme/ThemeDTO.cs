using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Domain.DTO
{
    public class ThemeDTO
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public List<QuestionDTO> Questions { get; set; }

    }
}
