import axios, { AxiosResponse } from 'axios'
import { Team } from '../interfaces/models/team.model'
import { BASE_URL } from '../shared/constants/base-url.constant'

const BASE_TEAM_URL = `${BASE_URL}/api/Teams`

export const TeamService = {
  fetchTeamData: async (): Promise<AxiosResponse<Team[]>> => {
    return axios.get(`${BASE_TEAM_URL}`)
  },

  deleteTeam: async (teamId: number): Promise<AxiosResponse<void>> => {
    return axios.delete(`${BASE_TEAM_URL}/${teamId}`)
  }
}
