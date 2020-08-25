import './App.css'

import 'bootstrap/dist/css/bootstrap.min.css'

import React from 'react'
import Logo from '../template/Logo'
import Footer from '../template/Footer'
import Main from '../template/Main'


export default props=>
    <React.Fragment>
        <Logo/>
        <Main/>
        <Footer/>
    </React.Fragment>