import { useState } from 'react';
import { Button } from 'react-bootstrap';
import { AddTeamModalComponent } from '../../components/modals/add-team.modal.component';

export function AddTeamModalContainer() {

    const [show, setShow] = useState(false);

    const handleClose = () => {setShow(false)};
    const handleOpen = () => {setShow(true)};

    return (
        <div>
            <Button onClick={handleOpen}>Add Match</Button>
            <AddTeamModalComponent show={show} handleClose={handleClose}></AddTeamModalComponent>
        </div>
    );
}