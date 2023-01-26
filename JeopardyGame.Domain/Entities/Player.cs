namespace JeopardyGame.Domain.Entities;

public class Player : Entity
{
    public int GameId { get; set; }

    public int UserId { get; set; }

    public int Score { get; set; }

    public Role Role { get; set; }

    public Game Game { get; set; }

    public User User { get; set; }
}