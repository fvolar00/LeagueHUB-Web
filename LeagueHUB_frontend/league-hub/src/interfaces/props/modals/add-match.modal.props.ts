import { AddMatchFormModel } from '../../models/form/add-match.form.model'
import { Referee } from '../../models/referee.model'
import { Team } from '../../models/team.model'
import { ModalProps } from './modal.props'

export interface AddMatchModalProps extends ModalProps<AddMatchFormModel> {
  teams: Team[]
  referees: Referee[]
}
