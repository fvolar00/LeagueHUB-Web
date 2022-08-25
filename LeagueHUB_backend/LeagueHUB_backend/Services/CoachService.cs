using LeagueHUB_backend.Enums;
using LeagueHUB_backend.Interfaces.Repos;
using LeagueHUB_backend.Interfaces.Services;
using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Services
{
    public class CoachService : ICoachService
    {
        private readonly ICoachRepository _coachRepository;
        private readonly ITeamService _teamService;

        public CoachService(ICoachRepository coachRepository, ITeamService teamService)
        {
            _coachRepository = coachRepository;
            _teamService = teamService;
        }

        public void Assign(int id, int teamid)
        {
            Coach coach = _coachRepository.GetCoach(id);
            Team team = _teamService.GetTeam(teamid);
            coach.Team = team;
            _coachRepository.UpdateCoach(coach);
        }

        public void CreateCoach(string name)
        {
            Coach coach = new Coach();
            coach.Name = name;
            _coachRepository.CreateCoach(coach);
        }

        public void DeleteCoach(int id)
        {
            Coach coach = _coachRepository.GetCoach(id);
            _coachRepository.DeleteCoach(coach);
        }

        public List<Coach> GetCoaches()
        {
            var coaches = _coachRepository.GetCoaches();
            return coaches;
        }

        public void UpdateCoach(int id, TacticType tactic)
        {
            Coach coach = _coachRepository.GetCoach(id);
            coach.Tactic = tactic;
            _coachRepository.UpdateCoach(coach);
        }
    }
}
