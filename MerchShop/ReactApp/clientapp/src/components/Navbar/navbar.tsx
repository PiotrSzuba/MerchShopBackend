import React from 'react';
import './navbar.scss'
import { NavLink } from "react-router-dom";
import { RiShoppingCartLine } from 'react-icons/ri';
import {VscAccount} from 'react-icons/vsc';

function Navbar(){
    return (
        <div className="navbar-container">
            <div className="navbar-content">
                <div className="force-left">
                    <NavLink className="navbar-link logo-font" to="/">MerchShop</NavLink>
                </div>
                <div className="force-right">
                    <NavLink className="navbar-link" to="/AddIttem">Add item</NavLink>
                    <NavLink className="navbar-link" to="/Cart"><RiShoppingCartLine/> Cart</NavLink>
                    <NavLink className="navbar-link" to="/Account"><VscAccount/> Account</NavLink>
                </div>
            </div>
        </div>
    );
}

export default Navbar;