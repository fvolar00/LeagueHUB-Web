import { Referee } from '../models/referee.model';
import { Team } from '../models/team.model'

export interface ModalProps {
  show: boolean;
  handleClose: () => void;
  teams: Team[];
  referees: Referee[];
}
