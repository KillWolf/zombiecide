import React, { Component } from 'react'
import ReactDOM from 'react-dom';
import BoardApi from '../../api'
import { Link } from 'react-router-dom'
import './board.css'

// The Player looks up the player using the number parsed from
// the URL's pathname. If no player is found with the given
// number, then a "player not found" message is displayed.

class Board extends Component {

    constructor(props) {
        super(props);

        this.state = {
            input: '',
            board: this.getBoardDetails(),
            isEditing: false
        }

        let styles = {
            display: 'flex',
            backgroundColor: 'red'
        }

        const editState = (
            <div id="panel" className="panel">
                <div>
                    <div className="header">
                        <input value={this.state.board.boardName} onChange={this.updateInputState.bind(this)}/>

                        <div className="editButton" onClick={this.updateState.bind(this)}>Edit</div>
                    </div>
                    <div>{this.state.board.boardDesc}</div>
                </div>
                <div>
                    <Link to='/board-list'>Back</Link>
                </div>
            </div>
        )


        const showState = (
            <div id="panel" className="panel">
                <div>
                    <div className="header">
                        <h1>{this.state.board.boardName}</h1>
                        <div className="editButton" onClick={this.updateState.bind(this)}>Edit</div>
                    </div>
                    <div>{this.state.board.boardDesc}</div>
                </div>
                <div>
                    <Link to='/board-list'>Back</Link>
                </div>
            </div>
        )

        this.showState = showState;
        this.editState = editState;


    }

    updateInputState(e) {
        this.setState({ input: e.target.value })
    }

    editInformation() {
        this.setState({ isEditing: true })
    }

    updateState() {
        this.setState({ isEditing: true })
    }

    updateInformation(e) {
        BoardApi.update(parseInt(this.props.match.params.boardId, 10), this.state.input)
        this.setState({ board: this.getBoardDetails() })
        console.log(this.editState);
        ReactDOM.render(this.editState, document.getElementById('panel'))
    }

    getBoardDetails() {
        const board = BoardApi.get(
            parseInt(this.props.match.params.boardId, 10)
        )
        return board;
    }

    render() {

        if (!this.state.board) {
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
                    <img src={this.state.board.boardImg} alt="" width="750" />
                </div>
                {this.state.isEditing ? this.editState : this.showState}
            </div>
        )

    }
}

export default Board;


