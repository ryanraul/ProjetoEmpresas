import './Main.css'
import React from 'react'
import Header from '../header/Header'

export default props=>
    <React.Fragment>
        <Header />
        <main className="content form-area">
            <div className="p-3 mt-3 mb-3">
                {props.children}
            </div>
        </main>
    </React.Fragment>