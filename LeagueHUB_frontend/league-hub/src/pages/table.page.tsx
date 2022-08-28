import { Col, Container, Row } from 'react-bootstrap'
import { AddMatchModalContainer } from '../containers/modals/add-match.modal.container'
import { TableContainer } from '../containers/table.container'
import { VerticalNavbarContainer } from '../containers/vertical-navbar.container'
import { useState } from 'react'

export function TablePage() {
  const [updated, setUpdated] = useState(false)
  const update = () => {
    setUpdated(!updated)
  }

  return (
    <Container>
      <Row>
        <Col xl={2}>
          <VerticalNavbarContainer></VerticalNavbarContainer>
        </Col>
        <Col lg={10}>
          <Row>
            <Col>
              <TableContainer updated={updated}></TableContainer>
            </Col>
          </Row>
          <Row>
            <Col lg={10}></Col>
            <Col sm={2}>
              <AddMatchModalContainer update={update}></AddMatchModalContainer>
            </Col>
          </Row>
        </Col>
      </Row>
    </Container>
  )
}
