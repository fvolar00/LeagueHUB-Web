import { useEffect, useState } from 'react'
import { Button } from 'react-bootstrap'
import { AddTeamModalComponent } from '../../components/modals/add-team.modal.component'
import { Referee } from '../../interfaces/models/referee.model'
import { Team } from '../../interfaces/models/team.model'
import { RefereeService } from '../../services/referee.service'
import { TeamService } from '../../services/team.service'

export function AddTeamModalContainer() {
  const [show, setShow] = useState(false)

  const handleClose = () => {
    setShow(false)
  }
  const handleOpen = () => {
    setShow(true)
  }

  const [teamData, setTeamData] = useState([] as Team[])
  async function fetchTeamData() {
    try {
      // setLoading(true);
      const teams = await TeamService.fetchTeamData()
      setTeamData(teams.data)
    } finally {
      // setLoading(false);
    }
  }

  const [refereeData, setRefereeData] = useState([] as Referee[])
  async function fetchRefereeData() {
    try {
      // setLoading(true);
      const referees = await RefereeService.fetchRefereeData()
      setRefereeData(referees.data)
    } finally {
      // setLoading(false);
    }
  }

  useEffect(() => {
    fetchTeamData()
    fetchRefereeData()
  }, [])

  return (
    <div>
      <Button onClick={handleOpen}>Add Match</Button>
      <AddTeamModalComponent
        show={show}
        handleClose={handleClose}
        teams={teamData}
        referees={refereeData}
      ></AddTeamModalComponent>
    </div>
  )
}
