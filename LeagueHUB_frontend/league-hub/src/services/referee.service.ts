import axios, { AxiosResponse } from 'axios'
import { Referee } from '../interfaces/models/referee.model'
import { BASE_URL } from '../shared/constants/base-url.constant'

const BASE_REFEREE_URL = `${BASE_URL}/api/Referee`

export const RefereeService = {
  fetchRefereeData: async (): Promise<AxiosResponse<Referee[]>> => {
    return axios.get(`${BASE_REFEREE_URL}`)
  },
}
