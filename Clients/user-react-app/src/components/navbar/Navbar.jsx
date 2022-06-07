import { NavLink } from 'react-router-dom';

function Navbar() {
    return (
        <nav id="navbar">
            <h1 className='logo'>
                <span className='text-primary'>
                    <i className='fa-solid fa-graduation-cap'></i> Westcoast 
                </span>
                 Education
            </h1>
            <ul>
                <li>
                    <NavLink to='/'>Start</NavLink>
                </li>
            </ul>
        </nav>
    )
}

export default Navbar;