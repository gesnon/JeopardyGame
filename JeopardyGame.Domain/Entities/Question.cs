namespace JeopardyGame.Domain.Entities;

public class Question : Entity
{
    public string Text { get; set; }

    public string Answer { get; set; }

    public string? DataContent { get; set; }

    public int Price { get; set; }

    public QuestionType QuestionType { get; set; }
}