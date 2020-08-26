import React from 'react'

export default props=>
    <div>
    <hr/>
        <center><strong className="mb-3">Empresas Cadastradas</strong></center>
        <table className="table-person mt-3">
            <thead>
                <tr>
                <th scope="col">Cnpj</th>
                <th scope="col">Nome</th>
                <th scope="col">Fantasia</th>
                <th scope="col">Uf</th>
                <th scope="col">Situacao</th>
                <th scope="col">Operacoes</th>
                </tr>
            </thead>
            <tbody>
                {
                    props.empresas.map(empresa=>
                        <tr key={empresa.id}>
                            <td>{empresa.cnpj}</td>
                            <td>{empresa.nome}</td>
                            <td>{empresa.fantasia}</td>
                            <td>{empresa.uf}</td>
                            <td>{empresa.situacao}</td>
                            <td>
                                <a href={`#/empresa_detalhes/${empresa.cnpj}`} className="text-primario">Detalhes</a><br></br>
                                <a href={`#/delete/${empresa.id}`} className="text-primario">Deletar</a>
                            </td>
                        </tr>
                    )   
                }
                
            </tbody>
        </table>
    <hr/>
    </div>