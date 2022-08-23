using LeagueHUB_backend.Dto;
using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Interfaces.Services
{
    public interface IRefereeService
    {
        public List<GetRefereesDto> GetReferees();
        public bool RefereeExists(int id);
        public Referee GetReferee(int id);
        public void CreateReferee(string name);
        public void DeleteReferee(Referee referee);
    }
}
