import './Main.css'
import React from 'react'
import Header from './Header'

export default props=>
    <React.Fragment>
        <Header />
        <main className="content form-area">
            <div className="p-3 mt-3 mb-3">
                <h2>Main</h2>
            </div>
        </main>
    </React.Fragment>