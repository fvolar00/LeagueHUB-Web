using LeagueHUB_backend.Enums;
using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Interfaces.Services
{
    public interface ICoachService
    {
        public List<Coach> GetCoaches();
        public void CreateCoach(string name);
        public void UpdateCoach(int id, TacticType tactic);
        public void DeleteCoach(int id);
        public void Assign(int id, int teamid);
    }
}
