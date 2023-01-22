using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeopardyGame.Domain.Entities;

namespace JeopardyGame.Domain.DTO
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public string Answer { get; set; }

        public string? DataContent { get; set; }

        public int Price { get; set; }

        public QuestionType QuestionType { get; set; }
    }
}
