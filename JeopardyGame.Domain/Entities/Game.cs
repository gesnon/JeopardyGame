namespace JeopardyGame.Domain.Entities;

public class Game : Entity
{
    public string Name { get; set; }

    public int PackId { get; set; }

    public Pack Pack { get; set; }

    public List<Player> Players { get; set; }
}
