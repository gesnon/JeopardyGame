using JeopardyGame.Domain.Entities;

namespace JeopardyGame.Core.Models
{
    public class QuestionDto
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Answer { get; set; }

        public string? DataContent { get; set; }

        public int Price { get; set; }

        public QuestionType QuestionType { get; set; }
    }
}
