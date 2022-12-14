using LeagueHUB_backend.Interfaces.Repos;
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

        public bool AddTeam(string teamName, string coachName)
        {
            throw new NotImplementedException();
        }

        public void CreateTeam(Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();

        }

        public void DeleteTeam(int id)
        {
            Team team = _context.Teams.Find(id);
            _context.Teams.Remove(team);
            _context.SaveChanges();
        }

        public int GetGoalDifference(int id)
        {
            Team team = _context.Teams.Where(t => t.Id == id).FirstOrDefault();
            return team.GoalsScored - team.GoalsConceded;
        }

        public Team GetTeam(int id)
        {
            return _context.Teams.Find(id);
        }

        public List<Team> GetTeams()
        {
            return _context.Teams.OrderByDescending(p => p.Points).ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool TeamExists(int id)
        {
            return _context.Teams.Any(p => p.Id == id);
        }

        public bool TeamExists(string name)
        {
            return _context.Teams.Any(p => p.Name == name);
        }

        public void UpdateTeam(Team team)
        {
            _context.Update(team);
            _context.SaveChanges();
        }
    }
}
