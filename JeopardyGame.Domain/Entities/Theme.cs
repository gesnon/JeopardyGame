namespace JeopardyGame.Domain.Entities;

public class Theme : Entity
{
    public string Title { get; set; }

    public List<Question> Questions { get; set; }
}