namespace JeopardyGame.Core.Models
{
    public class PackDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public List<RoundDto> Rounds { get; set; }
    }
}
