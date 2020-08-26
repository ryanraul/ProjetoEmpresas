import React from 'react'

import Home from '../pages/home/Home'
import CadEmpresa from '../pages/cadastro/CadEmpresa'
import { Switch, Route, Redirect } from 'react-router'

export default props=>
    <Switch>
        <Route exact path="/" component={Home}/>
        <Route exact path="/cad_empresas" component={CadEmpresa}/>
        <Redirect from="*" to="/"/>
    </Switch>