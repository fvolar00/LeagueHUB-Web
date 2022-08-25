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
using AutoMapper;
using LeagueHUB_backend.Dto;
using LeagueHUB_backend.Interfaces.Repos;
using LeagueHUB_backend.Interfaces.Services;
using LeagueHUB_backend.Enums;

namespace LeagueHUB_backend.Controllers
{
    [ApiController]
    public class TeamsController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }     

        [HttpGet, Route("api/[controller]")]
        public IActionResult GetTeams()
        {
            var teams = _teamService.GetTeams();
            return Ok(teams);
        }

        [HttpPost, Route("api/[controller]/create")]
        public IActionResult CreateTeam(string name)
        {
            _teamService.CreateTeam(name);
            return Ok();
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
