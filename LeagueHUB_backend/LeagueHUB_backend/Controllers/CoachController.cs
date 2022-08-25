using LeagueHUB_backend.Enums;
using LeagueHUB_backend.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace LeagueHUB_backend.Controllers
{
    [ApiController]
    public class CoachController : Controller
    {
        private readonly ICoachService _coachService;
        public CoachController(ICoachService coachService)
        {
            _coachService = coachService;
        }
        [HttpGet, Route("api/coaches")]
        public IActionResult GetCoaches()
        {
            var coaches = _coachService.GetCoaches();
            return Ok(coaches);
        }

        [HttpPost, Route("api/[controller]/create")]
        public IActionResult CreateCoach(string name)
        {
            _coachService.CreateCoach(name);
            return Ok();
        }

        [HttpPut, Route("api/[controller]/updatetactics")]
        public IActionResult UpdateCoach(int id, TacticType tactic)
        {
            _coachService.UpdateCoach(id, tactic);
            return Ok();
        }

        [HttpPut, Route("api/[controller]/assignteam")]
        public IActionResult Assign(int id, int teamid)
        {
            _coachService.Assign(id, teamid);
            return Ok();
        }

        [HttpDelete, Route("api/[controller]/delete")]
        public IActionResult DeleteCoach(int id)
        {
            _coachService.DeleteCoach(id);
            return Ok();
        }
    }
}
