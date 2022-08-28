using AutoMapper;
using LeagueHUB_backend.Dto;
using LeagueHUB_backend.Interfaces.Repos;
using LeagueHUB_backend.Interfaces.Services;
using LeagueHUB_backend.Models;
using System.Collections.Generic;

namespace LeagueHUB_backend.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        private readonly ITeamService _teamService;
        private readonly IRefereeService _refereeService;
        private readonly IMapper _mapper;
        public GameService(IGameRepository gameRepository, ITeamService teamService, IRefereeService refereeService, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _teamService = teamService;
            _refereeService = refereeService;
            _mapper = mapper;
        }

        public void CreateGame(MatchDto match)
        { 
            Team home = _teamService.GetTeam(match.homeTeamId);
            Team guest = _teamService.GetTeam(match.guestTeamId);          
            Referee referee = _refereeService.GetReferee(match.refereeId);
            Game game = new Game();
            game.Home = home;
            game.Guest = guest;
            game.Referee = referee;
            game.HomeScore = match.homeTeamScore;
            game.GuestScore = match.guestTeamScore;
            game.date = match.gameDate;
            if(match.homeTeamScore > match.guestTeamScore)
            {
                home.Won();
                guest.Lost();
            }
            else if (match.homeTeamScore == match.guestTeamScore)
            {
                home.Tied();
                guest.Tied();
            }
            else
            {
                home.Lost();
                guest.Won();
            }
            home.GoalsScored += match.homeTeamScore;
            guest.GoalsScored += match.guestTeamScore;
            home.GoalsConceded += match.guestTeamScore;
            guest.GoalsConceded += match.homeTeamScore;
            _teamService.UpdateTeam(home);
            _teamService.UpdateTeam(guest);
            _gameRepository.CreateGame(game);
        }

        public List<GamesDto> GetGames()
        {
            var matches = _mapper.Map<List<GamesDto>>(_gameRepository.GetGames());
            return matches;
        }
    }
}
