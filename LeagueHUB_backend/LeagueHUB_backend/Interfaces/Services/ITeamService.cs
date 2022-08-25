﻿using LeagueHUB_backend.Dto;
using LeagueHUB_backend.Models;

namespace LeagueHUB_backend.Interfaces.Services
{
    public interface ITeamService
    {
        public List<GetTeamsDto> GetTeams();
    }
}