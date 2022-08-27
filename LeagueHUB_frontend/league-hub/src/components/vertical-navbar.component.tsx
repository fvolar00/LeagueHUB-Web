import { Nav } from 'react-bootstrap'

export function VerticalNavbarComponent() {
  return (
    <Nav defaultActiveKey='/home' className='flex-column bg-warning'>
      <label>LeagueHub</label>
      <Nav.Link href='/'>Manage Team</Nav.Link>
      <Nav.Link eventKey=''>Manage Coach</Nav.Link>
      <Nav.Link eventKey=''>Manage Game</Nav.Link>
    </Nav>
  )
}
