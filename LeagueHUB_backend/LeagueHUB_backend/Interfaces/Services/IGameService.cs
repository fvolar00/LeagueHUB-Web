using LeagueHUB_backend.Dto;
using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Interfaces.Services
{
    public interface IGameService
    {
        public List<GamesDto> GetGames();
        public void CreateGame(MatchDto match);
    }
}
