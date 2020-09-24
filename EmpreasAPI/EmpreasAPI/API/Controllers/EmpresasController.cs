using EmpreasAPI.Domain.Entities;
using EmpreasAPI.Domain.Handlers;
using EmpreasAPI.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpreasAPI.Controllers
{
    [ApiController]
    [Route("v1/empresas")]
    public class EmpresasController : ControllerBase
    {
        
        public ActionResult<Empresa> VerificarEmpresa(Empresa empresa)
        {
            if(empresa == null)
                return Ok(new { message = "Empresa nao encontrada" });
            return empresa;
        }


        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Empresa>>> Get()
        {
            var empresaHandler = new EmpresaHandler();
            
            var empresas = await empresaHandler.GetEmpresasGeral();
            if (!empresas.Any())
                return Ok(new { message = "Nenhuma empresa encontrada" });
            return empresas;
        }

        [HttpGet]
        [Route("CNPJ/{cnpj}")]
        public async Task<ActionResult<Empresa>> GetByCnpj(string cnpj)
        {
            var empresa = await new EmpresaHandler().GetEmpresaCnpj(cnpj);
            return VerificarEmpresa(empresa);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Empresa>> GetById(int id)
        {
            var empresa = await new EmpresaHandler().GetEmpresaId(id);
            return VerificarEmpresa(empresa);
        }
        
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Empresa>> Post([FromBody] EmpresaWS model)
        {
            EmpresaHandler empresaHandler = new EmpresaHandler();
            if (empresaHandler.Validate(model.Cnpj))
            {
                
                var verificarCNPJ = await empresaHandler.GetEmpresaCnpj(model.Cnpj);

                if(verificarCNPJ != null)
                return Ok(new { message = "Cnpj ja Cadastrado" });

            
                var dataWs = await empresaHandler.GetEmpresaWS(model.Cnpj);
                
                if (dataWs.Value != null)
                {
                    var data = empresaHandler.Mapping(dataWs.Value);
                    await empresaHandler.AddEmpresa(data);
                    return data;
                }
                return dataWs.Result;
            }
            else
            {
                return Ok(new { message = "Cnpj Invalido" }); ;
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Empresa>> DeleteById(int id)
        {
            var empresaHandler = new EmpresaHandler();
            var empresa = await empresaHandler.GetEmpresaId(id);

            if(empresa == null)
                return Ok(new { message = "Empresa nao encontrada" });

            try
            {
                await empresaHandler.RemoveEmpresa(empresa);
                return empresa;
            }
            catch (Exception)
            {
                return Ok(new { message = "Nao foi possivel remover a empresa" });
            }
        }
    }
}
