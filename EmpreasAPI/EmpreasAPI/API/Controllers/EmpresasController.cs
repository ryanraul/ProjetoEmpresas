using EmpreasAPI.API.Mapping;
using EmpreasAPI.Domain.Entities;
using EmpreasAPI.Domain.Handlers;
using EmpreasAPI.Domain.Models;
using EmpreasAPI.Domain.Repository;
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
            var empresaRopository = new EmpresaRepository();
            
            var empresas = await empresaRopository.GetEmpresas();
            if (!empresas.Any())
                return Ok(new { message = "Nenhuma empresa encontrada" });
            return empresas;
        }

        [HttpGet]
        [Route("CNPJ/{cnpj}")]
        public async Task<ActionResult<Empresa>> GetByCnpj(string cnpj)
        {
            var empresaRopository = new EmpresaRepository();
            if (new EmpresaWS().ValidateCNPJ(cnpj))
            {
                var empresa = await new EmpresaRepository().GetEmpresaCnpj(cnpj);
                return VerificarEmpresa(empresa);
            }
            return Ok(new { message = "Cnpj Invalido" }); ;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Empresa>> GetById(int id)
        {
            var empresa = await new EmpresaRepository().GetEmpresaId(id);
            return VerificarEmpresa(empresa);
        }
        
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Empresa>> Post([FromBody] EmpresaWS model)
        {
            var empresaRopository = new EmpresaRepository();
            if (model.ValidateCNPJ(model.Cnpj))
            {
                
                var verificarCNPJ = await empresaRopository.GetEmpresaCnpj(model.Cnpj);

                if(verificarCNPJ != null)
                    return Ok(new { message = "Cnpj ja Cadastrado" });

            
                var dataWs = await new EmpresaHandler().GetEmpresaWS(model.Cnpj);
                
                if (dataWs.Value != null)
                {
                    var data = MappingEmpresa.MappingEmpresaWStoEmpresa(dataWs.Value);
                    await empresaRopository.AddEmpresa(data);
                    return data;
                }
                return dataWs.Result;
            }
            return Ok(new { message = "Cnpj Invalido" });
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Empresa>> DeleteById(int id)
        {
            var empresaRopository = new EmpresaRepository();
            var empresa = await empresaRopository.GetEmpresaId(id);

            if(empresa == null)
                return Ok(new { message = "Empresa nao encontrada" });

            try
            {
                await empresaRopository.RemoveEmpresa(empresa);
                return empresa;
            }
            catch (Exception)
            {
                return Ok(new { message = "Nao foi possivel remover a empresa" });
            }
        }
    }
}
