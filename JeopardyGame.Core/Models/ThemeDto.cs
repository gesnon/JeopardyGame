namespace JeopardyGame.Core.Models
{
    public class ThemeDto
    {
        public string Title { get; set; }

        public int Id { get; set; }

        public List<QuestionDto> Questions { get; set; }
    }
}
