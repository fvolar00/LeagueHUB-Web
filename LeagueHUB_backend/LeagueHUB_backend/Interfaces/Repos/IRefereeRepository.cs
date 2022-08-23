using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Interfaces.Repos
{
    public interface IRefereeRepository
    {
        public List<Referee> GetReferees();
        public bool RefereeExists(int id);
        public Referee GetReferee(int id);
        public void CreateReferee(Referee referee);
        public void DeleteReferee(Referee referee);
    }
}
