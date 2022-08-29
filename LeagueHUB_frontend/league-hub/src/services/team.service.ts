import axios, { AxiosResponse } from 'axios'
import { AddTeamFormModel } from '../interfaces/models/form/add-team.form.model'
import { Team } from '../interfaces/models/team.model'
import { BASE_URL } from '../shared/constants/base-url.constant'

const BASE_TEAM_URL = `${BASE_URL}/api/Teams`

export const TeamService = {
  fetchTeamData: async (): Promise<AxiosResponse<Team[]>> => {
    return axios.get(`${BASE_TEAM_URL}`)
  },

  deleteTeam: async (teamId: number): Promise<AxiosResponse<void>> => {
    return axios.delete(`${BASE_TEAM_URL}/${teamId}`)
  },

  addTeam: async (teamForm: AddTeamFormModel): Promise<AxiosResponse<void>> => {
    return axios.post(`${BASE_TEAM_URL}/create`, teamForm)
  },
}
