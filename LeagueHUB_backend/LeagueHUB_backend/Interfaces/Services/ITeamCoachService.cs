using LeagueHUB_backend.Enums;

namespace LeagueHUB_backend.Interfaces.Services
{
    public interface ITeamCoachService
    {
        public void CreateTeam(string teamname, string coachname, TacticType tactics);
    }
}
