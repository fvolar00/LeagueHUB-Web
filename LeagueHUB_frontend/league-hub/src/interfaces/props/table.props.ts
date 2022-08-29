import React from 'react'
import { Team } from '../models/team.model'

export interface TableProps {
  teams: Team[]
  deleteTeam: (e: React.MouseEvent) => {}
}
