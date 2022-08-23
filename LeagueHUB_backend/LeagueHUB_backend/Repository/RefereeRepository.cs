using LeagueHUB_backend.Interfaces.Repos;
using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Repository
{

    public class RefereeRepository : IRefereeRepository
    {
        private readonly LeagueHUBContext _context;
        public RefereeRepository(LeagueHUBContext context)
        {
            _context = context;
        }
        public void CreateReferee(Referee referee)
        {
            _context.Add(referee);
            _context.SaveChanges();
        }

        public void DeleteReferee(Referee referee)
        {
            _context.Remove(referee);
            _context.SaveChanges();
        }

        public Referee GetReferee(int id)
        {
            Referee referee = _context.Referees.Find(id);
            return referee;
        }

        public bool RefereeExists(int id)
        {
            var referee = _context.Referees.FirstOrDefault(x => x.Id == id);
            if (referee == null)
                return false;
            return true;
        }

        public List<Referee> GetReferees()
        {
            return _context.Referees.OrderBy(p => p.Id).ToList();
        }

    }
}
