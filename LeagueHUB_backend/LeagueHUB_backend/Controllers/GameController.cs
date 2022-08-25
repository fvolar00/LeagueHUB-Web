using LeagueHUB_backend.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace LeagueHUB_backend.Controllers
{
    [ApiController]
    public class GameController : Controller
    {
        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet, Route("api/[controller]/all")]
        public IActionResult GetGames()
        {
            var games = _gameService.GetGames();
            return Ok(games);
        }

        [HttpPost, Route("api/[controller]/create")]
        public IActionResult CreateGame(int homeid, int guestid, int refereeid, int homescore, int guestscore)
        {
            _gameService.CreateGame(homeid, guestid, refereeid, homescore, guestscore);
            return Ok();
        }
    }
}
