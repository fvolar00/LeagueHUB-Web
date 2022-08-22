using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Interfaces
{
    public interface ITeamRepository
    {
        public List<Team> GetTeams();
    }
}
