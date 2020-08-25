
import 'bootstrap/dist/css/bootstrap.min.css'
import 'font-awesome/css/font-awesome.min.css'

import '../main/App.css'
import React from 'react'
import Logo from '../template/Logo'
import Footer from '../template/Footer'
import Home from '../home/Home'


export default props=>
    <div className="app">
        <Logo/>
        <Home/>
        <Footer/>
    </div>