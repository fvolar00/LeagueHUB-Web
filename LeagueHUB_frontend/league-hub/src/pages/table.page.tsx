import { Col, Container, Row } from 'react-bootstrap'
import { AddTeamModalContainer } from '../containers/modals/add-team.modal.container'
import { TableContainer } from '../containers/table.container'
import { VerticalNavbarContainer } from '../containers/vertical-navbar.container'

export function TablePage() {
  return (
    <Container>
      <Row>
        <Col xl={2}>
          <VerticalNavbarContainer></VerticalNavbarContainer>
        </Col>
        <Col lg={10}>
          <Row>
            <Col>
              <TableContainer></TableContainer>
            </Col>
          </Row>
          <Row>
            <Col lg={10}></Col>
            <Col sm={2}>
              <AddTeamModalContainer></AddTeamModalContainer>
            </Col>
          </Row>
        </Col>
      </Row>
    </Container>
  )
}
