using LeagueHUB_backend.Enums;

namespace LeagueHUB_backend.Models
{
    public class Competitor
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }
        public Team Team { get; set; }
    }

    public class Coach : Competitor
    {
        public TacticType Tactic { get; set; }
    }
    public class Player : Competitor
    {
        public PositionType Position { get; set; }
    }
}
