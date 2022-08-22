using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeagueHUB_backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc.Routing;
using LeagueHUB_backend.Interfaces;

namespace LeagueHUB_backend.Controllers
{
    [ApiController]
    public class TeamsController : Controller
    {
        private readonly ITeamRepository _teamRepository;

        public TeamsController(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        [HttpGet, Route("api/[controller]")]
        public IActionResult GetTeams()
        {
            return Ok(_teamRepository.GetTeams());
        }
        

        //[HttpGet, Route("api/[controller]/Names")]
        //public async Task<ActionResult<List<Team>>> GetTeamNames()
        //{
        //    List<Team> teams = await _context.Teams.ToListAsync();
        //    List<string> teamNames = new List<string>();
        //    teams.ForEach(team => teamNames.Add(team.Name));
        //    return Ok(teamNames);
        //}


    }
}
