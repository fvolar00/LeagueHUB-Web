using AutoMapper;
using LeagueHUB_backend.Enums;
using LeagueHUB_backend.Interfaces.Repos;
using LeagueHUB_backend.Interfaces.Services;
using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Services
{
    public class TeamCoachService : ITeamCoachService
    {
        private readonly ITeamRepository _teamRepository;
        private readonly ICoachRepository _coachRepository;

        public TeamCoachService(ITeamRepository teamRepository, ICoachRepository coachRepository)
        {
            _teamRepository = teamRepository;
            _coachRepository = coachRepository;
        }

        public void CreateTeam(string teamname, string coachname, TacticType tactics)
        {
            if (_teamRepository.TeamExists(teamname))
                throw new Exception("Team already exists");
            else
            {
                Team team = new Team();
                Coach coach = new Coach();
                coach.Name = coachname;
                coach.Team = team;
                coach.Tactic = tactics;
                team.Name = teamname;
                _teamRepository.CreateTeam(team);
                _coachRepository.CreateCoach(coach);
            }               
        }
    }
}
