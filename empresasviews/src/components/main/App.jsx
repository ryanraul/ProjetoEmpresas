
import 'bootstrap/dist/css/bootstrap.min.css'

import '../main/App.css'
import React from 'react'
import Logo from '../template/Logo'
import Footer from '../template/Footer'
import Main from '../template/Main'


export default props=>
    <div className="app">
        <Logo/>
        <Main/>
        <Footer/>
    </div>