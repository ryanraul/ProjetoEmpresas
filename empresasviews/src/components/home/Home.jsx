import React from 'react'
import Main from '../template/Main'

export default props =>
    <Main>
        <div className="display-4 font-weight-bold">Bem vindo </div>
            <hr/>
            <p className="mb-3 mt-4">
                Sistema realiza o cadastro de empresas a partir de seu Cnpj, é realizado uma requisicao
                para uma API responsavel por fazer busca do Cnpj no web service da receita federal, e 
                armazenar as informacoes adquirida em uma base de dados
            </p>
        
    </Main>    