using EmpreasAPI.Infrastructure.Queries;
using EmpreasAPI.Domain.Entities;
using EmpreasAPI.Domain.Mapping;
using EmpreasAPI.Domain.Models;
using EmpreasAPI.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmpreasAPI.Domain.Handlers
{
    public class EmpresaHandler
    {
        public bool ValidateCNPJ(string cnpj)
        {
            return cnpj.Length == 14 ? true : false;
        }

        public async Task<ActionResult<EmpresaWS>> GetEmpresaWS(string cnpj)
        {
            RequestWS request = new RequestWS();
            return await request.RequestWebService(cnpj);
        }

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

        public async Task<List<Empresa>> GetEmpresas()
        {
            return await EmpresaQueries.ListEmpresas();
        }

        public async Task<Empresa> GetEmpresaCnpj(string cnpj)
        {
            return await EmpresaQueries.ListEmpresaCnpj(cnpj);
        }

        public async Task<Empresa> GetEmpresaId(int id)
        {
            return await EmpresaQueries.ListEmpresaId(id);
        }

        public async Task AddEmpresa(Empresa empresa)
        {
            await EmpresaQueries.SaveAddedEmpresa(empresa);
        }

        public async Task RemoveEmpresa(Empresa empresa)
        {
            await EmpresaQueries.SaveRemovedEmpresa(empresa);
        }


    }
}
