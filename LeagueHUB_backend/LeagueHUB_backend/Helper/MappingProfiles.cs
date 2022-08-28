using AutoMapper;
using LeagueHUB_backend.Dto;
using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Team, TeamsDto>();
            CreateMap<Referee, RefereesDto>();
        }
    }
}
