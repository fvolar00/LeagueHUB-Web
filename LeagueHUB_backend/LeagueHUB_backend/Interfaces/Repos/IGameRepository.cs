using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Interfaces.Repos
{
    public interface IGameRepository
    {
        public List<Game> GetGames();
        public void CreateGame(Game game);
        public void DeleteTeamGames(int id);
    }
}
