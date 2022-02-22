import React from 'react';
import './styles/index.scss'
import Navbar from './components/Navbar/navbar'
import { Route, Routes } from "react-router-dom";
import Home from "./pages/Home";
import Account from "./pages/Account";
import Cart from "./pages/Cart";
import ItemPage from "./pages/Item";
import AddItemPage from "./pages/AddItem";

function App() {
  document.title = "MerchShop"
  return (
    <div>
      <Navbar/>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/Cart" element={<Cart />} />
          <Route path="/Account" element={<Account />} />
          <Route path="/Item/:id" element={<ItemPage />} />
          <Route path="/AddIttem" element={<AddItemPage/>} />
        </Routes>
    </div>
  );
}

export default App;
