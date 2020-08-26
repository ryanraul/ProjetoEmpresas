import '../styles/main.css'

import React, { Component } from 'react'

import Main from '../../template/main/Main'
import api from '../../../Api/api'
import TabelaDetalhes from './TabelaDetalhes'
//import api from '../../../Api/api'

const initialState = {
    cnpj: '',
    carregado: false,
    info: []
}

export default class ListaEmpresas extends Component{

    state = {...initialState}

    componentWillMount(){
        let cnpj_id = this.props.match.params;
        this.setState({cnpj: cnpj_id.cnpj})
    } 

    async componentDidMount(){
        const cnpj = this.state.cnpj
        const response = await api.get('/Cnpj/'+ cnpj)
        this.setState({info: response.data})

    }

    renderTable(){
        const { info } = this.state
        
        if(info != null){
            const keys = Object.keys(info)
            return(
                <React.Fragment>
                    <center><strong className="mb-3">Mais informacoes da Empresa (Cnpj: {info.cnpj})</strong></center>
                    <TabelaDetalhes keys={keys} {...this.state} />
                </React.Fragment>
                
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