import React, { Component, useState } from 'react';
import Home from './components/Home';
import { Routes, Route } from "react-router-dom";
import MenuBar from './components/MenuBar';
import Vender from './components/Vender';


export default function App() {

  return (
    <div>

      <MenuBar ></MenuBar>
      <Routes>
        <Route index path="/" element={<Home />} />
        <Route path="vender" element={<Vender />} />
      </Routes>
    </div >
  );

}
