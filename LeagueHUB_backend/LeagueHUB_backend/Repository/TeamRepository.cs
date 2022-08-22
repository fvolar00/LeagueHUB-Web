using LeagueHUB_backend.Interfaces;
using LeagueHUB_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeagueHUB_backend.Repository
{
    public class TeamRepository : ITeamRepository
    {
        private readonly LeagueHUBContext _context;
        public TeamRepository(LeagueHUBContext context)
        {
            _context = context;
        }
        
        public List<Team> GetTeams()
        {
            return _context.Teams.OrderBy(p => p.Points).ToList();
        }
    }
}
