import '../styles/main.css'

import React from 'react'
import { Component } from 'react'

import Main from '../../template/main/Main'
import InfoCad from './InfoCad'
import api from '../../../Api/api'

const initialState = {
    cnpj: '',
    carregado: false,
    info: []
}

export default class CadEmpresa extends Component{

    state = {...initialState}

    async cadastrar(e){
        const cnpj = this.state.cnpj
        this.setState({carregado: true})
        const response = await api.get('/Cnpj/'+cnpj)
        this.setState({info: response.data})
        console.log(response.data)
    }

    updateField(e){
        var cnpj = this.state.cnpj
        cnpj = e.target.value
        this.setState({cnpj})
    }

    clear(){
        this.setState({cnpj: initialState.cnpj})
    }

    renderForm(){
        return(
            <div className="form">
                <center><h2 className="mt-3">Cadastro de empresa</h2></center>
                <hr/>
                    <div className="input-cnpj form-group">
                        <label><strong>Insira o Cnpj: </strong></label>
                        <input type="text" className="form-control"
                            name="cnpj" value={this.state.cnpj}
                            onChange={e=>this.updateField(e)}
                            placeholder="Digite o Cnpj"/>
                    </div>
                <hr/>
                <div className="col-12 d-flex justify-content-end">
                    <button className="btn-op" onClick={e=>this.cadastrar(e)}>Cadastrar</button>
                    <button className="btn-op ml-2" onClick={e=>this.clear(e)}>Cancelar</button>
                </div>
            </div>
        )
    }

    renderInfo(){
        const {carregado, info} = {...this.state}

        if(info.status === 'OK'){
            return(
                <InfoCad {...this.state}/>
            )
        }else if(info.message != null){
            return(
                <center><h5 className="font-weight-bold mt-4 mb-4"><span className="text-primario fa fa-exclamation-circle mr-2" />{info.message}</h5></center>
            )
        }
        if(carregado){
            return(
                <div>
                    <center><h5 className="font-weight-bold mt-4 mb-4">Carregando...</h5></center>
                </div>
            )
        }
    }

    render(){
        return(
            <Main>
                {this.renderForm()}
                {this.renderInfo()}
            </Main>
        )
    }

}