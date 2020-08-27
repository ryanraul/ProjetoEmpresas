import '../styles/main.css'

import React, { Component } from 'react'

import Main from '../../template/main/Main'
import api from '../../../Api/api'
import TabelaEmpresas from './TabelaEmpresas'
import MensagemErro from './MensagemErro'

const initialState = {
    carregado: false,
    empresas: []
}

export default class ListaEmpresas extends Component{

    state = {...initialState}

    async componentDidMount(){
        this.setState({carregado: true})
        const response = await api.get('').catch(error=> this.setState({carregado: initialState.carregado}))
        if(this.state.carregado !== false){
            this.setState({empresas: response.data})  
        }   
    }

    renderTable(){
        const {empresas, carregado} = this.state
            if(empresas.length !== undefined && empresas.length !== 0){
                return(
                    <TabelaEmpresas {...this.state}/>
                )
            }else if(empresas.message != null){
                return(
                    <center><h5 className="font-weight-bold mt-4 mb-4"><span className="text-primario fa fa-exclamation-circle mr-2" />{empresas.message}</h5></center>
                )
            }else if(carregado){
                return(
                    <center><h5 className="font-weight-bold mt-4 mb-4">Carregando...</h5></center>
                )
            }else{
                return(
                     <MensagemErro/>
                )   
            } 
    }

    render(){
        return(
            <Main>
                {this.renderTable()}
            </Main>
        )
    }
}