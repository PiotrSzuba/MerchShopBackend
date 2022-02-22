import React from 'react';
import axios from 'axios';
import {ItemCardView} from '../components/ItemCardView/ItemCardView';


export default class Home extends React.Component {

    state = {
        genericItems: []
    }

    componentDidMount() {
        axios.get('https://localhost:7159/api/GenericItems/')
          .then(res => {
            console.log(res);
            const genericItems = res.data;
            this.setState({ genericItems });
            document.title = "MerchShop";
          })
      }

    render(){
        return (
            <div className="container ">
                <div className="home-container ">
                    {this.state.genericItems.map(item => <ItemCardView title={item.name} price={item.price} id = {item.id} />)}
                </div>
            </div>
        );
    }
}