using AutoMapper;
using LeagueHUB_backend.Dto;
using LeagueHUB_backend.Interfaces.Repos;
using LeagueHUB_backend.Interfaces.Services;
using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Services
{
    public class RefereeService : IRefereeService
    {
        private readonly IRefereeRepository _refereeRepository;
        private readonly IMapper _mapper;

        public RefereeService(IRefereeRepository refereeRepository, IMapper mapper)
        {
            _refereeRepository = refereeRepository;
            _mapper = mapper;
        }
        public void CreateReferee(string name)
        {
            Referee referee = new Referee();
            referee.Name = name;
            _refereeRepository.CreateReferee(referee);
        }

        public void DeleteReferee(Referee referee)
        {
            throw new NotImplementedException();
        }

        public Referee GetReferee(int id)
        {
            throw new NotImplementedException();
        }

        public List<GetRefereesDto> GetReferees()
        {
            var referees = _mapper.Map<List<GetRefereesDto>>(_refereeRepository.GetReferees());
            return referees;
        }

        public bool RefereeExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
