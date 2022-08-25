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
            CreateMap<Game, GamesDto>().ForMember(t => t.HomeName, opt => opt.MapFrom(t => t.Home.Name))
                .ForMember(t => t.GuestName, opt => opt.MapFrom(t => t.Guest.Name))
                .ForMember(t => t.RefereeName, opt => opt.MapFrom(t => t.Referee.Name));
        }
    }
}
