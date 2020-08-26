import React from 'react'
import Main from '../../template/main/Main'
import GitLogo from '../../../assets/GitHub-Mark/PNG/gitlogo32.png'

export default props =>
    <Main>
        <div className="display-4 font-weight-bold">Bem vindo </div>
            <hr/>
            <p className="mb-3 mt-4">
                Sistema realiza o cadastro de empresas a partir de seu Cnpj, é realizado uma requisicao
                para uma API responsavel por fazer busca do Cnpj no web service da receita federal, e 
                armazenar as informacoes adquirida em uma base de dados
            </p>
        <center><a href="https://github.com/ryanraul/ProjetoEmpresas" className="btn btn-dark text-light">Repositorio do Projeto <img src={GitLogo} alt="gitlogo"></img></a></center>  
    </Main>    