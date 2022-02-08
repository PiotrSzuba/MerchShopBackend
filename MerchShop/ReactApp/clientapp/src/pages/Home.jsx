import React from 'react';
import {ItemCardView} from '../components/ItemCardView/ItemCardView';

function Home(){
    const items = []
    var rows = 6;

    for (var i = 0; i < rows; i++) {
        items.push(<ItemCardView title={"Home"} price={99.9} id = {i} />)
    }

    return (
        <div className="container ">
            <div className="home-container ">
                {items}
            </div>
        </div>
    );
}

export default Home;