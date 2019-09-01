import React from 'react';
import './Navbar.css'
import { Link } from 'react-router-dom'

function Navbar() {
    return (
        <nav>
            <div className="siteHeader">ZOMBICIDE</div>
            <ul>
                <li><Link to='/'>Home</Link></li>
                <li><Link to='/board-list'>Boards</Link></li>
            </ul>
        </nav>
    );
  }
  
  export default Navbar;