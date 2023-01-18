namespace JeopardyGame.Domain.Entities;

public class Round : Entity
{
    public int Order { get; set; }

    public List<Theme> Themes { get; set; }
}