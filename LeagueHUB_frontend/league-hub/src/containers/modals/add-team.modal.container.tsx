import { FormEventHandler, useState } from 'react'
import { Dropdown } from 'react-bootstrap'
import { AddTeamModalComponent } from '../../components/modals/add-team.modal.component'
import { AddTeamFormModel } from '../../interfaces/models/form/add-team.form.model'
import { RenderActionProps } from '../../interfaces/props/render/render-action.props'
import { TeamService } from '../../services/team.service'

export function AddTeamModalContainer({ update }: RenderActionProps) {
  const [show, setShow] = useState(false)
  const handleClose = () => {
    setShow(false)
  }
  const handleOpen = () => {
    setShow(true)
  }

  const teamFormInitState: AddTeamFormModel = {
    name: '',
  }

  const [teamForm, setTeamForm] = useState(teamFormInitState)
  const onFormChange = (e: { target: { name: any; value: any } }) => {
    const name = e.target.name
    const value = e.target.value
    setTeamForm({ ...teamForm, [name]: value })
  }
  const submitHandler: FormEventHandler = (event) => {
    event.preventDefault()
    event.persist()
    addTeam()
    handleClose()
  }

  async function addTeam() {
    try {
      await TeamService.addTeam(teamForm)
    } finally {
      update()
      setTeamForm(teamFormInitState)
    }
  }

  return (
    <>
      <Dropdown.Item onClick={handleOpen}>Teams</Dropdown.Item>
      <AddTeamModalComponent
        show={show}
        onFormChange={onFormChange}
        submitHandler={submitHandler}
        handleClose={handleClose}
        form={teamForm}
      ></AddTeamModalComponent>
    </>
  )
}
