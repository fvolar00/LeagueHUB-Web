using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Interfaces.Repos
{
    public interface ITeamRepository
    {
        public List<Team> GetTeams();
        public Team GetTeam(int id);
        public bool TeamExists(int id);
        public bool TeamExists(string name);
        public int GetGoalDifference(int id);
        public bool Save();
        public void CreateTeam(Team team);

    }
}
