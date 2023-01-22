namespace JeopardyGame.Core.Models
{
    public class RoundDto
    {
        public int Order { get; set; }

        public int Id { get; set; }

        public List<ThemeDto> Themes { get; set; }
    }
}
