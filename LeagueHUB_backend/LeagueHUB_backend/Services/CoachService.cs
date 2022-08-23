using LeagueHUB_backend.Interfaces.Repos;
using LeagueHUB_backend.Interfaces.Services;
using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Services
{
    public class CoachService : ICoachService
    {
        private readonly ICoachRepository _coachRepository;

        public CoachService(ICoachRepository coachRepository)
        {
            _coachRepository = coachRepository;
        }

        public List<Coach> GetCoaches()
        {
            var coaches = _coachRepository.GetCoaches();
            return coaches;
        }
    }
}
