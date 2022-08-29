import { ManageDropdownComponent } from '../components/manage-dropdown.component'
import { ManagementProps } from '../interfaces/props/management.props'

export function ManageDropdownContainer({ update }: ManagementProps) {
  return <ManageDropdownComponent update={update}></ManageDropdownComponent>
}
