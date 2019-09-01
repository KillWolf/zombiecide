import React from 'react'
import BoardApi from '../../api'
import { Link } from 'react-router-dom'
import './board.css'

// The Player looks up the player using the number parsed from
// the URL's pathname. If no player is found with the given
// number, then a "player not found" message is displayed.
const Board = (props) => {
    const board = BoardApi.get(
        parseInt(props.match.params.number, 10)
    )

    if (!board) {
        return (
            <div>
                Sorry, but the player was not found
                <Link to='/board-list'>Back to the list</Link>
            </div>
        )
    }

    return (
        <div className="boardContainer">
            <div className="board">
                <img src={board.boardImg} alt="" width="750" />
            </div>
            <div className="panel">
                <div>
                    <h1>{board.boardName}</h1>
                    <div>{board.boardDesc}</div>
                </div>
                <div>
                    <Link to='/board-list'>Back</Link>
                </div>
            </div>
        </div>
    )
}

export default Board;


