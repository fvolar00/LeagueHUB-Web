import axios, { AxiosResponse } from 'axios';
import { Team } from '../interfaces/team.interface';

const BASE_TEAM_URL = 'https://localhost:7068/Teams'
// const BASE_TEAM_URL = '/api/Teams'

export const TeamService = {
    fetchTeamData: async (): Promise<AxiosResponse<Team[]>> => {
        return axios.get(`${BASE_TEAM_URL}`);
    }
}
