import { Referee } from '../models/referee.model';
import { Team } from '../models/team.model'

export interface ModalProps {
  show: boolean;
  handleClose: () => void;
  teams: Team[];
  referees: Referee[];
  onFormChange: (e: { target: { name: any; value: any } }) => void;
  submitHandler: (event: any) => void;
}
