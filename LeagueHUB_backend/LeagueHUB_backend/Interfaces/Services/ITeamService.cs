using LeagueHUB_backend.Dto;
using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Interfaces.Services
{
    public interface ITeamService
    {
        public List<TeamsDto> GetTeams();
        public Team GetTeam(int id);
        public void CreateTeam(string name);
        public void UpdateTeam(Team team);
        void DeleteTeam(int id);
    }
}
