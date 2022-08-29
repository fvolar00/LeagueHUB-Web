import { Modal, Form, Button } from 'react-bootstrap'
import { AddTeamModalProps } from '../../interfaces/props/modals/add-team.modal.props'

export function AddTeamModalComponent({
  show,
  form,
  handleClose,
  submitHandler,
  onFormChange,
}: AddTeamModalProps) {
  return (
    <Modal show={show} onHide={handleClose}>
      <Modal.Header closeButton>
        <Modal.Title>Add Team</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <Form>
          <Form.Label>Team Name</Form.Label>
          <Form.Control
            type='text'
            onChange={onFormChange}
            name='name'
            value={form.name}
          ></Form.Control>
        </Form>
      </Modal.Body>
      <Modal.Footer>
        <Button variant='secondary' onClick={handleClose}>
          Close
        </Button>
        <Button variant='primary' onClick={submitHandler}>
          Save Changes
        </Button>
      </Modal.Footer>
    </Modal>
  )
}
