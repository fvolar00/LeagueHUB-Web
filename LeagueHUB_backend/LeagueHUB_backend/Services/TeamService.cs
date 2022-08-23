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

        public List<GetTeamsDto> GetTeams()
        {
            var teams = _mapper.Map<List<GetTeamsDto>>(_teamRepository.GetTeams());
            return teams;
        }

    }
}
