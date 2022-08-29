import { useEffect, useState } from 'react'
import { Spinner } from 'react-bootstrap'
import { TableComponent } from '../components/table.component'
import { Team } from '../interfaces/models/team.model'
import { RenderProps } from '../interfaces/props/render.props'
import { TeamService } from '../services/team.service'

export function TableContainer({ updated }: RenderProps) {
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

  return (
    <div>
      <TableComponent teams={teamData}></TableComponent>
      {loading && <Spinner animation='border' variant='secondary' />}
    </div>
  )
}
