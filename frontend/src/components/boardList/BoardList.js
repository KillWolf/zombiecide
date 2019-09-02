import React from 'react';
import { Link } from 'react-router-dom'
import BoardsApi from '../../api'
import './BoardList.css'
import SingleBoardCard from '../singleBoardCard/SingleBoardCard'


function BoardList() {

    return (
        <div className="pageContainer">
            <div className="cardContainer">
            {/* INDEX IS NOT IDEAL, USE BOARD ID TO TRACK LIST */}
                {BoardsApi.all().map((board, index) => (
                    <Link to={`/board/${board.boardId}`} key={index}>
                        < SingleBoardCard boardName={board.boardName} boardImg={board.boardImg} boardDesc={board.boardDesc} />
                    </Link>))}
            </div>
        </div>
    );
}

export default BoardList;