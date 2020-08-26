import React from 'react'

export default props=>
    <React.Fragment>
        <hr/>
        <center><strong className="mb-3">Mais informacoes da Empresa (Cnpj:)</strong></center>
            <table className="table-person mt-3">
                <thead>
                    {
                        props.keys.map(function(key){
                            if(key !== "atividade_principal" && key !== "atividades_secundarias" && key !== "qsa" && key !== "billing" && key !== "message" && props.info[key] !== ''){
                                return(
                                    <tr>
                                        <th key={key} scope="col">{key}</th>
                                        <td>{props.info[key]}</td>
                                    </tr>
                                )
                            }else{return(null)}    
                        })
                    }           
                </thead>
                <tbody>
                    <tr>
                    </tr>
                </tbody>
            </table>
        <hr/>
    </React.Fragment>
