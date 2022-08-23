using LeagueHUB_backend.Interfaces.Repos;
using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Repository
{
    public class CoachRepository : ICoachRepository
    {
        private readonly LeagueHUBContext _context;
        public CoachRepository(LeagueHUBContext context)
        {
            _context = context;
        }

        public bool CoachExists(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateCoach(Coach coach)
        {
            _context.Add(coach);
            _context.SaveChanges();
        }

        public void DeleteCoach(Coach coach)
        {
            throw new NotImplementedException();
        }

        public Coach GetCoach(int id)
        {
            Coach coach = _context.Coaches.Find(id);
            return coach;
        }

        public List<Coach> GetCoaches()
        {
            return _context.Coaches.OrderBy(p => p.Name).ToList();
        }

        public void UpdateCoach(Coach coach)
        {
            throw new NotImplementedException();
        }
    }
}
