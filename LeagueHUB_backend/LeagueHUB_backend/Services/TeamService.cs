using AutoMapper;
using LeagueHUB_backend.Dto;
using LeagueHUB_backend.Interfaces.Repos;
using LeagueHUB_backend.Interfaces.Services;
using LeagueHUB_backend.Models;
using LeagueHUB_backend.Repository;

namespace LeagueHUB_backend.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;
        public TeamService(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }

        public void CreateTeam(string name)
        {
            Team team = new Team();
            team.Name = name;
            _teamRepository.CreateTeam(team);
        }

        public void DeleteTeam(int id)
        {
            _teamRepository.DeleteTeam(id);
        }

        public Team GetTeam(int id)
        {
            Team team = _teamRepository.GetTeam(id);
            return team;
        }

        public List<TeamsDto> GetTeams()
        {
            var teams = _mapper.Map<List<TeamsDto>>(_teamRepository.GetTeams());
            return teams;
        }

        public void UpdateTeam(Team team)
        {
            _teamRepository.UpdateTeam(team);
        }
    }
}
