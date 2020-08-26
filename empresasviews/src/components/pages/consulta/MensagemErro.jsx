import React from 'react'

export default props=>
    <React.Fragment>
        <center>
            <h5 className="font-weight-bold mt-4 mb-4"><span className="text-primario fa fa-exclamation-circle mr-2" />Ocorreu algum problema!</h5>
            <h4>Possiveis soluções</h4>
        </center>
        <div className="input-cnpj">
            <ul>
                <li>Execute a API no Visual Studio</li>
                <li>Verifique a porta em que foi inicializada a API no Visual Studio</li>
                <li>Verifique a porta em que esta conectado a API em (../empresasviews/src/Api/api.js)</li>
            </ul>
            <h6>
                Alguma duvida de como funciona o sistema consulte o <a href="https://github.com/ryanraul/ProjetoEmpresas">Readme no repositorio do GitHub</a>
            </h6>
        </div>
    </React.Fragment> 