import '../styles/main.css'

import React from 'react'
import { Component } from 'react'

import Main from '../../template/main/Main'
import InfoCad from './InfoCad'

const initialState = {
    cnpj: '',
    carregado: false,
    info: []
}

export default class CadEmpresa extends Component{

    state = {...initialState}


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
                    <button className="btn-op" onClick={e=>this.clear(e)}>Cadastrar</button>
                    <button className="btn-op ml-2" onClick={e=>this.clear(e)}>Cancelar</button>
                </div>
            </div>
        )
    }


    render(){
        return(
            <Main>
                {this.renderForm()}
                <InfoCad {...this.state}/>
            </Main>
        )
    }

}