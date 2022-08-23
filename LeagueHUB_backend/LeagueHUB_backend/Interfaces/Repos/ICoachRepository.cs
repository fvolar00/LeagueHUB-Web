using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Interfaces.Repos
{
    public interface ICoachRepository
    {
        public List<Coach> GetCoaches();
        public bool CoachExists(int id);
        public Coach GetCoach(int id);
        public void CreateCoach(Coach coach);
        public void UpdateCoach(Coach coach);
        public void DeleteCoach(Coach coach);
    }
}
