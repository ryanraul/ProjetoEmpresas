
import 'bootstrap/dist/css/bootstrap.min.css'
import 'font-awesome/css/font-awesome.min.css'
import './App.css'

import React from 'react'
import { HashRouter } from 'react-router-dom'

import Logo from '../template/logo/Logo'
import Footer from '../template/footer/Footer'
import Routes from '../app/Routes'

export default props=>
    <HashRouter>
        <div className="app">
            <Logo/>
            <Routes/>
            <Footer/>
        </div>
    </HashRouter>