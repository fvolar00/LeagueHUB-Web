namespace LeagueHUB_backend.Models
{
    public class Referee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Game> Games { get; set; }
    }
}
