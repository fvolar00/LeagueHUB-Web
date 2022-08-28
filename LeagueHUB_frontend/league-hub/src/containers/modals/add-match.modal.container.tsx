import { FormEventHandler, useEffect, useState } from 'react'
import { Button } from 'react-bootstrap'
import { AddMatchModalComponent } from '../../components/modals/add-match.modal.component'
import { AddMatchFormModel } from '../../interfaces/models/add-match-form.model'
import { Referee } from '../../interfaces/models/referee.model'
import { Team } from '../../interfaces/models/team.model'
import { RenderActionProps } from '../../interfaces/props/render-action.props'
import { GameService } from '../../services/game.service'
import { RefereeService } from '../../services/referee.service'
import { TeamService } from '../../services/team.service'

export function AddMatchModalContainer({ update }: RenderActionProps) {
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
      const teams = await TeamService.fetchTeamData()
      setTeamData(teams.data)
    } finally {
      console.log
    }
  }

  const [refereeData, setRefereeData] = useState([] as Referee[])
  async function fetchRefereeData() {
    try {
      const referees = await RefereeService.fetchRefereeData()
      setRefereeData(referees.data)
    } finally {
      console.log
    }
  }

  useEffect(() => {
    fetchTeamData()
    fetchRefereeData()
  }, [])

  const [matchForm, setMatchForm] = useState({
    homeTeamId: -1,
  guestTeamId: -1,
  homeTeamScore: 0,
  guestTeamScore: 0,
  refereeId: -1,
  gameDate: new Date(),
  } as AddMatchFormModel)
  const onFormChange = (e: { target: { name: any; value: any } }) => {
    const name = e.target.name
    const value = e.target.value
    setMatchForm({ ...matchForm, [name]: value })
  }
  const submitHandler: FormEventHandler = (event) => {
    event.preventDefault()
    event.persist()
    addMatch()
    handleClose()
  }

  async function addMatch() {
    try {
      await GameService.addMatch(matchForm)
    } finally {
      update()
    }
  }

  return (
    <div>
      <Button onClick={handleOpen}>Add Match</Button>
      <AddMatchModalComponent
        show={show}
        handleClose={handleClose}
        teams={teamData}
        referees={refereeData}
        form={matchForm}
        onFormChange={onFormChange}
        submitHandler={submitHandler}
      ></AddMatchModalComponent>
    </div>
  )
}
