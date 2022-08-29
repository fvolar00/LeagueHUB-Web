import axios, { AxiosResponse } from 'axios'
import { AddMatchFormModel } from '../interfaces/models/form/add-match.form.model'
import { BASE_URL } from '../shared/constants/base-url.constant'

const BASE_GAME_URL = `${BASE_URL}/api/Game`

export const GameService = {
  addMatch: (matchForm: AddMatchFormModel): Promise<AxiosResponse> => {
    return axios.post(`${BASE_GAME_URL}/create`, matchForm)
  },
}
