using EmpreasAPI.Infrastructure.Queries;
using EmpreasAPI.Domain.Entities;
using EmpreasAPI.Domain.Models;
using EmpreasAPI.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmpreasAPI.Domain.Handlers
{
    public class EmpresaHandler
    {

        public async Task<ActionResult<EmpresaWS>> GetEmpresaWS(string cnpj)
        {
            RequestWS request = new RequestWS();
            return await request.RequestWebService(cnpj);  
        }

    }
}
