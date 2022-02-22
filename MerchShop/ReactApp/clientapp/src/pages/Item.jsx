import React from 'react';
import axios from 'axios';
import "./item.scss";


export default class ItemPage extends React.Component {
    state = {
        items: [],
        image: ""
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
      
      componentWillUnmount(){
        this.state.items = [];
      }

      bin2String(array) {
        return String.fromCharCode.apply(String, array);
      }

      render(){
        document.title = this.state.items.name
          return(
            <div className="container">
              <div className="row">
                  <div className="column left">
                    <img className= "preview-image" alt = "No content" src="https://i.pinimg.com/originals/c8/bd/a9/c8bda99ff35a1aca879a77d8dfb84dd2.jpg"/>            
                  </div>
                  <div className="column right">            
                      <h1 className = "title">{this.state.items.name}</h1>
                      <h4>{this.state.items.price} zł</h4>
                      <p>OnDiscount: {String(this.state.items.onDiscount)}</p>
                      <p>discountValue: {String(this.state.items.discountValue)}</p>
                      <p>IS_IN_STOCK: {String(this.state.items.isInStock)}</p>
                  </div>
              </div>
            </div>
          )
      }
}