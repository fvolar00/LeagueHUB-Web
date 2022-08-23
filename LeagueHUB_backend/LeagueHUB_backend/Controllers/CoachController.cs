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
    }
}
