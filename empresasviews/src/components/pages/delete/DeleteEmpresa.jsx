import '../styles/main.css'

import React, { Component } from 'react'

import Main from '../../template/main/Main'
import api from '../../../Api/api'
import TabelaDetalhes from '../consultaDetalhes/TabelaDetalhes'
//import api from '../../../Api/api'

const initialState = {
    id: '',
    carregado: false,
    info: []
}

export default class DeleteEmpresa extends Component{

    state = {...initialState}

    componentWillMount(){
        let param_id = this.props.match.params;
        this.setState({id: param_id.id})
    } 

    async componentDidMount(){
        const id = this.state.id
        const response = await api.get('/'+ id)
        this.setState({info: response.data})
    }

    async deletar(op){
        const empresa = {...this.state}
        await api.delete('/'+empresa.id);
        this.setState({carregado: true, info: initialState.info})
    }

    renderTable(){
        const { info, carregado } = this.state
        if(Object.keys(info).length !== 0){
            const keys = Object.keys(info)
            return(
                <React.Fragment>
                    <center>
                        <strong className="mb-3 text-danger">CONFIRME A EXCLUSÃO DA EMPRESA: </strong>
                        <button className="btn btn-danger font-weight-bold ml-2" onClick={e=>this.deletar(e)}>DELETAR</button>
                    </center>
                    <TabelaDetalhes keys={keys} {...this.state} />
                </React.Fragment>
                    
            )
        }else if(carregado){
            return(
                <React.Fragment>
                    <center><h5 className="font-weight-bold mt-4 mb-4"><span className="text-primario fa fa-exclamation-circle mr-2" />EMPRESA EXCLUIDA</h5></center>
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