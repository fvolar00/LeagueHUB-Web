import { Dropdown, DropdownButton } from 'react-bootstrap'

export function ManageDropdownComponent() {
  return (
    <DropdownButton id="dropdown-basic-button" title="Management">
    <Dropdown.Item href="/">Teams</Dropdown.Item>
    <Dropdown.Item href="/">Coaches</Dropdown.Item>
    <Dropdown.Item href="/">Referees</Dropdown.Item>
  </DropdownButton>
  )
}
