namespace LeagueHUB_backend.Dto
{
    public class MatchDto
    {
        public int homeTeamId { get; set; }
        public int guestTeamId { get; set; }
        public int homeTeamScore { get; set; }
        public int guestTeamScore { get; set; }
        public int refereeId { get; set; }
        public DateTime gameDate { get; set; }
    }
}
