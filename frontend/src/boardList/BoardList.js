import React from 'react';
import cover from '../assets/images/1.jpeg'
import './BoardList.css'
import SingleBoard from '../SingleBoard/SingleBoard'


function BoardList() {
    let boards = [];
    for (var i = 1; i <= 27; i++) {
        boards.push({ boardName: 'SmallTown' + i, boardImg: cover, boardDesc: 'fuck this nigga' })
    }

    return (
        <div className="pageContainer">
            <div className="cardContainer">
                {boards.map((item, index) => < SingleBoard key={index} boardName={item.boardName} boardImg={item.boardImg} boardDesc={item.boardDesc} />)}
            </div>
        </div>
    );
}

export default BoardList;