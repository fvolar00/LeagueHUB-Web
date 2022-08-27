import { FormEventHandler, useEffect, useState } from 'react'
import { Button } from 'react-bootstrap'
import { AddMatchModalComponent } from '../../components/modals/add-match.modal.component'
import { AddMatchFormModel } from '../../interfaces/models/add-match-form.model'
import { Referee } from '../../interfaces/models/referee.model'
import { Team } from '../../interfaces/models/team.model'
import { GameService } from '../../services/game.service'
import { RefereeService } from '../../services/referee.service'
import { TeamService } from '../../services/team.service'

export function AddMatchModalContainer() {
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

  const [fetch, setFetch] = useState(false)
  const toggleFetch = () => {
    setFetch(!fetch)
  }

  useEffect(() => {
    fetchTeamData()
    fetchRefereeData()
  }, [fetch])

  const [matchForm, setMatchForm] = useState({} as AddMatchFormModel)
  const onFormChange = (e: { target: { name: any; value: any } }) => {
    const name = e.target.name
    const value = e.target.value
    setMatchForm({ ...matchForm, [name]: value })
    // console.log(name, value);
  }
  const submitHandler: FormEventHandler = (event) => {
    event.preventDefault()
    event.persist()
    // console.log('push data somewhere :)')
    // console.log(matchForm);
    addMatch();
    handleClose();
    toggleFetch()
  }

  async function addMatch() {
    try {
      // setLoading(true);
      await GameService.addMatch(matchForm)
    } finally {
      // setLoading(false);
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
        onFormChange={onFormChange}
        submitHandler={submitHandler}
      ></AddMatchModalComponent>
    </div>
  )
}
