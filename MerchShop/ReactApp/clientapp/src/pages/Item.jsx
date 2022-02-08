import React, { useEffect, useState } from 'react';
import axios from 'axios';


export default class ItemPage extends React.Component {
    state = {
        items: []
    }

    GetId(){
        var id = window.location.pathname.replace("/item/","");
    
        return id;
    }

    componentDidMount() {
        axios.get('https://localhost:7159/api/GenericItems/' + this.GetId())
          .then(res => {
            console.log(res);
            const items = res.data;
            this.setState({ items });
            document.title = this.state.items.name
          })
      }

      bin2String(array) {
        return String.fromCharCode.apply(String, array);
      }

      render(){
          return(
            <div className="container ">
                <div>            
                    <p>{this.GetId()}</p>
                    <p>ID: {this.state.items.id}</p>
                    <p>NAME: {this.state.items.name}</p>
                    <p>PRICE: {this.state.items.price}</p>
                    <p>OnDiscount: {String(this.state.items.onDiscount)}</p>
                    <p>discountValue: {String(this.state.items.discountValue)}</p>
                    <p>IS_IN_STOCK: {String(this.state.items.isInStock)}</p>
                </div>
            </div>
          )
      }
}