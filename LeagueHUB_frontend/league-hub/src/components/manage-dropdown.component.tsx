import { DropdownButton } from 'react-bootstrap'
import { AddTeamModalContainer } from '../containers/modals/add-team.modal.container'
import { ManagementProps } from '../interfaces/props/management.props'

export function ManageDropdownComponent({ update }: ManagementProps) {
  return (
    <DropdownButton id='dropdown-basic-button' title='Management'>
      <AddTeamModalContainer update={update}></AddTeamModalContainer>
    </DropdownButton>
  )
}
