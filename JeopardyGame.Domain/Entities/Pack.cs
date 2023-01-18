namespace JeopardyGame.Domain.Entities;

public class Pack : Entity
{
    public string Title { get; set; }

    public string Author { get; set; }

    public List<Round> Rounds { get; set; }
}
