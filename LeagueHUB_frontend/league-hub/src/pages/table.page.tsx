import { Col, Row } from 'react-bootstrap'
import { TableContainer } from '../containers/table.container'
import { VerticalNavbarContainer } from '../containers/vertical-navbar.container'

export function TablePage() {
  return (
    <div className="flex-row">
      <Row>
<Col sm={2}>
<VerticalNavbarContainer></VerticalNavbarContainer>
</Col>
<Col>
<TableContainer></TableContainer>
</Col>
      </Row>
    </div>
  );
}
