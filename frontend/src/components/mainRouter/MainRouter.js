import React from 'react'
import { Switch, Route } from 'react-router-dom'
import Home from '../home/Home'
import BoardList from '../boardList/BoardList'
import Board from '../board/board'

const Main = () => (
    <main>
        <Switch>
            <Route exact path='/' component={Home} />
            <Route path='/board-list' component={BoardList} />
            <Route path='/board/:boardId' component={Board} />
        </Switch>
    </main>
)

export default Main
