import { useEffect, useState } from 'react'
import { TableComponent } from '../components/table.component'
import { Team } from '../interfaces/models/team.model'
import { TeamService } from '../services/team.service'

export function TableContainer() {
  const [teamData, setTeamData] = useState([] as Team[])

  useEffect(() => {
    fetchTeamData()
  }, [])

  async function fetchTeamData() {
    try {
      // setLoading(true);
      const teams = await TeamService.fetchTeamData()
      setTeamData(teams.data)
    } finally {
      // setLoading(false);
    }
  }

  return <TableComponent teams={teamData}></TableComponent>
}
