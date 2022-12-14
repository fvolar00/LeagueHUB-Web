using LeagueHUB_backend.Interfaces.Repos;
using LeagueHUB_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace LeagueHUB_backend.Repository
{
    public class GameRepository : IGameRepository
    {
        private readonly LeagueHUBContext _context;
        public GameRepository(LeagueHUBContext context)
        {
            _context = context;
        }

        public void CreateGame(Game game)
        {
            _context.Add(game);
            _context.SaveChanges();
        }

        public void DeleteTeamGames(int id)
        {
            var games = _context.Games.Where(x => x.Home.Id == id || x.Guest.Id == id).ToList();
            foreach (var game in games)
            {
                _context.Remove(game);
            }
            _context.SaveChanges();
        }

        public List<Game> GetGames()
        {
            List<Game> games = _context.Games.Include(game => game.Home).Include(game => game.Guest).Include(game => game.Referee).ToList();
            return games;
        }
    }
}
