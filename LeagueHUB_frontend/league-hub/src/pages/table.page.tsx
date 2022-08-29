import { Col, Container, Row } from 'react-bootstrap'
import { AddMatchModalContainer } from '../containers/modals/add-match.modal.container'
import { TableContainer } from '../containers/table.container'
import { ManageDropdownContainer } from '../containers/manage-dropdown.container'
import { useState } from 'react'

export function TablePage() {
  const [updated, setUpdated] = useState(false)
  const update = () => {
    setUpdated(!updated)
  }

  return (
    <Container fluid className='mt-4 mr-4 ml-4'>
      <Row>
        <Col sm={2} align='center'>
          <Row className='mb-2'>
            <AddMatchModalContainer updated={updated} update={update}></AddMatchModalContainer>
          </Row>
          <Row className='mt-2'>
            <ManageDropdownContainer update={update}></ManageDropdownContainer>
          </Row>
        </Col>
        <Col sm={10}>
          <TableContainer updated={updated} update={update}></TableContainer>
        </Col>
      </Row>
    </Container>
  )
}
