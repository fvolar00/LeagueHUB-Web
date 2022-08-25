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

        public void CreateGame(int homeid, int guestid, int refereeid, int homescore, int guestscore)
        {
            Team home = _teamService.GetTeam(homeid);
            Team guest = _teamService.GetTeam(guestid);          
            Referee referee = _refereeService.GetReferee(refereeid);
            Game game = new Game();
            game.Home = home;
            game.Guest = guest;
            game.Referee = referee;
            game.HomeScore = homescore;
            game.GuestScore = guestscore;
            if(homescore > guestscore)
            {
                home.Won();
                guest.Lost();
            }
            else if (homescore == guestscore)
            {
                home.Tied();
                guest.Tied();
            }
            else
            {
                home.Lost();
                guest.Won();
            }
            home.GoalsScored += homescore;
            guest.GoalsScored += guestscore;
            home.GoalsConceded += guestscore;
            guest.GoalsConceded += homescore;
            _teamService.UpdateTeam(home);
            _teamService.UpdateTeam(guest);
            _gameRepository.CreateGame(game);
        }

        public List<GamesDto> GetGames()
        {
            //var games = _mapper.Map<List<GamesDto>>(_gameRepository.GetGames());
            List<GamesDto> matches = new List<GamesDto>();
            List<Game> games = _gameRepository.GetGames();
            foreach (Game game in games)
            {
                GamesDto dto = new GamesDto();
                dto.Id = game.Id;
                dto.HomeName = game.Home.Name;
                dto.RefereeName = game.Referee.Name;
                dto.GuestName = game.Guest.Name;
                dto.date = game.date;
                dto.HomeScore = game.HomeScore;
                dto.GuestScore = game.GuestScore;
                matches.Add(dto);

            }
            return matches;
        }
    }
}
