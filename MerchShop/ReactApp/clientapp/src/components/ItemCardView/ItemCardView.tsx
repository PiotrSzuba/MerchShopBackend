import React, { useEffect, useState } from 'react';
import './ItemCardView.scss';
import { NavLink } from "react-router-dom";

type Arguments ={
    image?: string;
    title: string;
    price: number;
    width?: number;
    height?: number;
    id: number; 
}


export class ItemCardView extends React.Component<Arguments> {
    render() {
        return (
            <div className="card-container">
                <NavLink to = {{ pathname: `${"item"}/${this.props.id}`}}>
                    <img className= "card-image" src="https://i.pinimg.com/originals/c8/bd/a9/c8bda99ff35a1aca879a77d8dfb84dd2.jpg"/>
                    <div className="card-description">
                        <div className="card-description">
                            {this.props.title}
                        </div>
                        <div className="card-description">
                            {this.props.price} zł
                        </div>
                    </div>
                </NavLink>
            </div>
        );
    }
}
