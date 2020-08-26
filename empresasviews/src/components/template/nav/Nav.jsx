import './Nav.css'
import React from 'react'
import NavItems from './NavItems'

export default props=>
    <aside className="menu-area">
        <nav className="menu">
            <NavItems rout='home' className="navitems" icone='home' titulo='INICIO'/>
            <NavItems rout='cad_empresas' className="navitems" icone='building' titulo='CADASTRAR EMPRESA'/>
            <NavItems rout='list_empresas' className="navitems" icone='list' titulo='CONSULTAR EMPRESAS'/>
        </nav>
    </aside>