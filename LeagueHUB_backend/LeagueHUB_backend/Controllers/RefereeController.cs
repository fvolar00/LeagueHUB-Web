using AutoMapper;
using LeagueHUB_backend.Dto;
using LeagueHUB_backend.Interfaces.Repos;
using LeagueHUB_backend.Interfaces.Services;
using LeagueHUB_backend.Models;
using LeagueHUB_backend.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeagueHUB_backend.Controllers
{
    [ApiController]
    public class RefereeController : Controller
    {
        private readonly IRefereeService _refereeService;
        public RefereeController(IRefereeService refereeService)
        {
            _refereeService = refereeService;
        }

        [HttpGet, Route("api/[controller]")]
        public IActionResult GetReferees()
        {
            return Ok(_refereeService.GetReferees());
        }

        [HttpPost, Route("api/[controller]/create")]
        public IActionResult CreateReferee(string name)
        {
            _refereeService.CreateReferee(name);
            return Ok();
        }
        
    }
}
