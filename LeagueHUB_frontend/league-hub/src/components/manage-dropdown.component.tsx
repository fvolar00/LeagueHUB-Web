import { Dropdown, DropdownButton } from 'react-bootstrap'

export function ManageDropdownComponent() {
  return (
    <DropdownButton id="dropdown-basic-button" title="Management">
    <Dropdown.Item href="#/action-1">Teams</Dropdown.Item>
    <Dropdown.Item href="#/action-2">Coaches</Dropdown.Item>
    <Dropdown.Item href="#/action-3">Referees</Dropdown.Item>
  </DropdownButton>
  )
}
