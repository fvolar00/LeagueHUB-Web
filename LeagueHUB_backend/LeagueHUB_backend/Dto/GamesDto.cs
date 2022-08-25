using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Dto
{
    public class GamesDto
    {
        public int Id { get; set; }
        public string HomeName { get; set; }
        public string GuestName { get; set; }
        public string RefereeName { get; set; }
        public int HomeScore { get; set; }
        public int GuestScore { get; set; }
        public DateTime date { get; set; }
    }
}
