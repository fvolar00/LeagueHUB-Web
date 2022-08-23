namespace LeagueHUB_backend.Dto
{
    public class GetTeamsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
    }
}
