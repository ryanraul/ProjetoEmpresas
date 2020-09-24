using EmpreasAPI.Data.Queries;
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
            }catch(Exception)
            {
                return null;
            }
        }

        public bool Validate(string cnpj)
        {
            return cnpj.Length == 14 ? true : false;
        }

        public async Task<ActionResult<EmpresaWS>> GetEmpresaWS(string cnpj)
        {
            EmpresaWS empresaWS = new EmpresaWS();

            return await empresaWS.RequisicaoWebService(cnpj);

        }

        public async Task<List<Empresa>> GetEmpresasGeral()
        {
            return await EmpresaQueries.ListaEmpresas();
        }

        public async Task<Empresa> GetEmpresaCnpj(string cnpj)
        {
            return await EmpresaQueries.ListaEmpresasCnpj(cnpj);
        }

        public async Task<Empresa> GetEmpresaId(int id)
        {
            return await EmpresaQueries.ListaEmpresasId(id);
        }

        public async Task AddEmpresa(Empresa empresa)
        {
            await EmpresaQueries.SaveAddEmpresa(empresa);
        }

        public async Task RemoveEmpresa(Empresa empresa)
        {
            await EmpresaQueries.SaveRemoveEmpresa(empresa);
        }


    }
}
