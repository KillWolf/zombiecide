import React from 'react';
import './SingleBoardCard.css'

function SingleBoardCard(props) {
    return (
        <div className="singleCard">
            <img src={props.boardImg} alt="" width="300" />
            <div className="cardText">
                <h2>{props.boardName}</h2>
                <div>{props.boardDesc}</div>
            </div>
        </div>
    );
}

export default SingleBoardCard;