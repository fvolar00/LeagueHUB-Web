import { Button, Form, Modal, Row, Col } from 'react-bootstrap'
import { ModalProps } from '../../interfaces/props/modal.props'

export function AddTeamModalComponent({ show, handleClose, teams, referees }: ModalProps) {
  return (
    <Modal show={show} onHide={handleClose}>
      <Modal.Header closeButton>
        <Modal.Title>Add Match</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <Form>
          <Row className='mb-3'>
            <Col className="ml-2" md={6}>
              <Form.Group>
                <Form.Select aria-label='Select Home Team' value={-1}>
                  <option disabled value={-1} key={-1}>
                    Home Team
                  </option>
                  {teams.map((team, i) => (
                    <option key={i} value={team.id}>
                      {team.name}
                    </option>
                  ))}
                </Form.Select>
              </Form.Group>
            </Col>
            
            <Col className="mr-2" md={6}>
              <Form.Group>
                <Form.Select aria-label='Select Guest Team' value={-1}>
                  <option disabled value={-1} key={-1}>
                    Guest Team
                  </option>
                  {teams.map((team, i) => (
                    <option key={i} value={team.id}>
                      {team.name}
                    </option>
                  ))}
                </Form.Select>
              </Form.Group>
            </Col>
          </Row>
          <Row className="mb-2 p-2">
            <Col md={3}></Col>
            <Col md={2} className="p-1">
            <Form.Control type='text' name='home_score'></Form.Control>
            </Col>
            <Col className="" sm={2}></Col>
            <Col md={2} className="p-1">
            <Form.Control type='text' name='guest_score'></Form.Control>
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
                    <Form.Select aria-label='Select Game Referee' value={-1}>
                      <option disabled value={-1} key={-1}>
                        Referee
                      </option>
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
              <Form.Control type='date' name='game_date'></Form.Control>
            </Col>
          </Row>
        </Form>
      </Modal.Body>
      <Modal.Footer>
        <Button variant='secondary' onClick={handleClose}>
          Close
        </Button>
        <Button variant='primary' onClick={handleClose}>
          Save Changes
        </Button>
      </Modal.Footer>
    </Modal>
  )
}
