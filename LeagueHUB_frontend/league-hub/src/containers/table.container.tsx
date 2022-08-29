import React, { useEffect, useState } from 'react'
import { Spinner } from 'react-bootstrap'
import { TableComponent } from '../components/table.component'
import { Team } from '../interfaces/models/team.model'
import { RenderProps } from '../interfaces/props/render.props'
import { TeamService } from '../services/team.service'

export function TableContainer({ updated, update }: RenderProps) {
  const [teamData, setTeamData] = useState([] as Team[])
  const [loading, setLoading] = useState(false)

  async function fetchTeamData() {
    try {
      setLoading(true)
      const teams = await TeamService.fetchTeamData()
      setTeamData(teams.data)
    } finally {
      setLoading(false)
    }
  }

  useEffect(() => {
    fetchTeamData()
  }, [updated])

  async function deleteTeam(e: React.MouseEvent) {
    try {
      setLoading(true)
      const teams = await TeamService.deleteTeam(Number(e.currentTarget.getAttribute('value')))
    } finally {
      setLoading(false)
      update()
    }
  }

  return (
    <div>
      <TableComponent teams={teamData} deleteTeam={deleteTeam}></TableComponent>
      {loading && <Spinner animation='border' variant='secondary' />}
    </div>
  )
}
