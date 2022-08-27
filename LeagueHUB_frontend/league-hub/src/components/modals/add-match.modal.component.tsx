import { Button, Form, Modal, Row, Col } from 'react-bootstrap'
import { ModalProps } from '../../interfaces/props/modal.props'

export function AddMatchModalComponent({
  show,
  handleClose,
  teams,
  referees,
  onFormChange,
  submitHandler,
}: ModalProps) {
  return (
    <Modal show={show} onHide={handleClose}>
      <Modal.Header closeButton>
        <Modal.Title>Add Match</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <Form>
          <Row className='mb-3'>
            <Col className='ml-2' md={6}>
              <Form.Group>
                <Form.Label>Home team</Form.Label>
                <Form.Select
                  name='homeTeamId'
                  onChange={onFormChange}
                  aria-label='Select Home Team'
                >
                  {teams.map((team, i) => (
                    <option key={i} value={team.id}>
                      {team.name}
                    </option>
                  ))}
                </Form.Select>
              </Form.Group>
            </Col>

            <Col className='mr-2' md={6}>
              <Form.Group>
                <Form.Label>Guest team</Form.Label>
                <Form.Select
                  name='guestTeamId'
                  onChange={onFormChange}
                  aria-label='Select Guest Team'
                >
                  {teams.map((team, i) => (
                    <option key={i} value={team.id}>
                      {team.name}
                    </option>
                  ))}
                </Form.Select>
              </Form.Group>
            </Col>
          </Row>
          <Row className='mb-2 p-2'>
            <Col md={3}></Col>
            <Col md={2} className='p-1'>
              <Form.Control
                type='number'
                min='0'
                onChange={onFormChange}
                name='homeTeamScore'
              ></Form.Control>
            </Col>
            <Col sm={2} align='center' justify='center'>
              <div className='fs-3'>:</div>
            </Col>
            <Col md={2} className='p-1'>
              <Form.Control
                type='number'
                min='0'
                onChange={onFormChange}
                name='guestTeamScore'
              ></Form.Control>
            </Col>
          </Row>
          <Row>
            <Form.Group className='mb-3'>
              <Row>
                <Col className='ml-2' sm={2}>
                  <Form.Label className='mr-2 mt-1'>Referee</Form.Label>
                </Col>
                <Col sm={9} className='mr-3'>
                  <Form.Group>
                    <Form.Select
                      name='refereeId'
                      onChange={onFormChange}
                      aria-label='Select Game Referee'
                    >
                      {referees.map((referee, i) => (
                        <option key={i} value={referee.id}>
                          {referee.name}
                        </option>
                      ))}
                    </Form.Select>
                  </Form.Group>
                </Col>
              </Row>
            </Form.Group>
          </Row>
          <Row>
            <Col className='ml-2 mt-1' sm={2}>
              Date
            </Col>
            <Col className='mr-3' sm={9}>
              <Form.Control type='date' onChange={onFormChange} name='gameDate'></Form.Control>
            </Col>
          </Row>
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
