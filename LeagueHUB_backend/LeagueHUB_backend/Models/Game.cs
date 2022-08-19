namespace LeagueHUB_backend.Models
{
    public class Game
    {
        public int Id { get; set; }
        public Team Home { get; set; }
        public Team Guest { get; set; }
        public Referee Referee { get; set; }
        public int HomeScore { get; set; }
        public int GuestScore { get; set; }
        public DateTime date { get; set; }
    }
}
