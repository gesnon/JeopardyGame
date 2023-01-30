namespace JeopardyGame.Core.Models
{
    public class GameDto
    {        
        public string Name { get; set; }

        public UserDto Host { get; set; }

        public string? Password { get; set; }

        public int MaxPlayers { get; set; }

        public List<UserDto> Players { get; set; } = new List<UserDto>();

        public PackDto Pack { get; set; }
    }
}
