import React from 'react'

import Home from '../pages/home/Home'
import CadEmpresa from '../pages/cadastro/CadEmpresa'
import ListaEmpresas from '../pages/consulta/ListaEmpresas'
import { Switch, Route, Redirect } from 'react-router'

export default props=>
    <Switch>
        <Route exact path="/" component={Home}/>
        <Route exact path="/cad_empresas" component={CadEmpresa}/>
        <Route exact path="/list_empresas" component={ListaEmpresas}/>
        <Redirect from="*" to="/"/>
    </Switch>