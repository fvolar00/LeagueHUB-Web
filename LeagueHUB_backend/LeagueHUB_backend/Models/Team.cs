namespace LeagueHUB_backend.Models
{
    public class Team
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; } = 0;
        public int GamesPlayed { get; set; } = 0;
        public int Wins { get; set; } = 0;
        public int Draws { get; set; } = 0;
        public int Losses { get; set; } = 0;
        public int GoalsScored { get; set; } = 0;
        public int GoalsConceded { get; set; } = 0;
        public List<Player>? Players { get; set; }
        public Coach? Coach { get; set; }

        public void Won()
        {
            Points += 3;
            Wins += 1;
            GamesPlayed += 1;
        }
        public void Lost()
        {
            Losses += 1;
            GamesPlayed += 1;
        }
        public void Tied()
        {
            Points += 1;
            Draws += 1;
            GamesPlayed += 1;
        }


    }
}

