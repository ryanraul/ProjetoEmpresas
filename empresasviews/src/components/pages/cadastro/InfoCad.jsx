import React from 'react'

export default props =>
    <React.Fragment>
                <hr/>
                <strong className="mb-3">Algumas informacaoes da empresa cadastrada...</strong>
                <table className="table-person mt-3">
                    <thead>
                        <tr>
                        <th scope="col">Nome</th>
                        <th scope="col">Fantasia</th>
                        <th scope="col">Uf</th>
                        <th scope="col">Situacao</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>{props.info.nome}</td>
                            <td>{props.info.fantasia}</td>
                            <td>{props.info.uf}</td>
                            <td>{props.info.situacao}</td>
                        </tr>
                    </tbody>
                </table>
            <hr/>
    </React.Fragment>