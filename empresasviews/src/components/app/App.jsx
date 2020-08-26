
import 'bootstrap/dist/css/bootstrap.min.css'
import 'font-awesome/css/font-awesome.min.css'

import './App.css'
import React from 'react'
import Logo from '../template/logo/Logo'
import Footer from '../template/footer/Footer'
import Home from '../pages/home/Home'


export default props=>
    <div className="app">
        <Logo/>
        <Home/>
        <Footer/>
    </div>