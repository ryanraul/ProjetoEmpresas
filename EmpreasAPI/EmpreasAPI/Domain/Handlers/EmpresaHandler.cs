using EmpreasAPI.Domain.Entities;
using EmpreasAPI.Domain.Mapping;
using EmpreasAPI.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpreasAPI.Domain.Handlers
{
    public class EmpresaHandler
    {

        public Empresa Mapping(EmpresaWS empresaWS)
        {

            try
            {
                return MappingEmpresa.MappingEmpresaWStoEmpresa(empresaWS);
            }catch(Exception ex)
            {
                return null;
            }
        }
        
        public async Task<ActionResult<EmpresaWS>> GetEmpresaWS(string cnpj)
        {
            EmpresaWS empresaWS = new EmpresaWS();
            
            return await empresaWS.RequisicaoWebService(cnpj);
        }
        

    }
}
