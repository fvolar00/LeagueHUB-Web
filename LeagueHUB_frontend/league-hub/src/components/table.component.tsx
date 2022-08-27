import { useMemo } from 'react'
import { Table } from 'react-bootstrap'
import { TableProps } from '../interfaces/props/table.props'

export function TableComponent({ teams }: TableProps) {
return (
    <Table striped bordered hover variant='dark' className='flex-column'>
      <thead>
        <tr>
          <th>Rank</th>
          <th>Name</th>
          <th>Points</th>
          <th>Games Played</th>
          <th>Wins</th>
          <th>Draws</th>
          <th>Losses</th>
          <th>Goals Scored</th>
          <th>Goals Conceded</th>
          <th>Goal Difference</th>
        </tr>
      </thead>
      <tbody>
        {teams.map((team, i) => (
          <tr key={i}>
            <td>{i + 1}</td>
            <td>{team.name}</td>
            <td>{team.points}</td>
            <td>{team.gamesPlayed}</td>
            <td>{team.wins}</td>
            <td>{team.draws}</td>
            <td>{team.losses}</td>
            <td>{team.goalsScored}</td>
            <td>{team.goalsConceded}</td>
            <td>{team.goalsScored - team.goalsConceded}</td>
          </tr>
        ))}
      </tbody>
    </Table>
  )
}
