import React from 'react'

import Home from '../pages/home/Home'
import CadEmpresa from '../pages/cadastro/CadEmpresa'
import ListaEmpresas from '../pages/consulta/ListaEmpresas'
import EmpresaDetalhes from '../pages/consultaDetalhes/EmpresaDetalhes'
import DeleteEmpresa from '../pages/delete/DeleteEmpresa'

import { Switch, Route, Redirect } from 'react-router'

export default props=>
    <Switch>
        <Route exact path="/" component={Home}/>
        <Route exact path="/cad_empresas" component={CadEmpresa}/>
        <Route exact path="/list_empresas" component={ListaEmpresas}/>
        <Route exact path="/empresa_detalhes/:cnpj" component={EmpresaDetalhes}/>
        <Route exact path="/delete/:id" component={DeleteEmpresa}/>
        <Redirect from="*" to="/"/>
    </Switch>