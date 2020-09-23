using EmpreasAPI.Data;
using EmpreasAPI.Data.Queries;
using EmpreasAPI.Domain.Entities;
using EmpreasAPI.Domain.Handlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public async Task<ActionResult<List<Empresa>>> Get([FromServices] DataContext context)
        {
            var empresaHandler = new EmpresaHandler();
            
            var empresas = await empresaHandler.GetEmpresasGeral();
            if (!empresas.Any())
                return Ok(new { message = "Nenhuma empresa encontrada" });
            return empresas;
        }

        [HttpGet]
        [Route("CNPJ/{cnpj}")]
        public async Task<ActionResult<Empresa>> GetByCnpj(
            [FromServices] DataContext context,
            string cnpj)
        {
            var empresa = await EmpresaQueries.ListaEmpresasCnpj(cnpj);

            return VerificarEmpresa(empresa);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Empresa>> GetById(
            [FromServices] DataContext context,
            int id)
        {

            var empresa = await EmpresaQueries.ListaEmpresasId(id);

            return VerificarEmpresa(empresa);
        }
        
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Empresa>> Post(
            [FromServices] DataContext context,
            [FromBody] Empresa model)
        {
            EmpresaHandler empresaHandler = new EmpresaHandler();
            var verificarCNPJ = await empresaHandler.GetEmpresaCnpj(model.Cnpj);

            if(verificarCNPJ != null)
                return Ok(new { message = "Cnpj ja Cadastrado" });

            if (ModelState.IsValid)
            {
                var dataWs = await empresaHandler.GetEmpresaWS(model.Cnpj);
                
                if (dataWs != null)
                {
                    var data = empresaHandler.Mapping(dataWs.Value);
                    data.Cnpj = model.Cnpj;
                    await empresaHandler.AddEmpresa(context, data);
                    return data;
                }
                return Ok(new { message = "Houve algum problema..." });
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Empresa>> DeleteById(
            [FromServices] DataContext context,
            int id)
        {
            var empresaHandler = new EmpresaHandler();
            var empresa = await empresaHandler.GetEmpresaId(id);

            if(empresa == null)
                return Ok(new { message = "Empresa nao encontrada" });

            try
            {
                await empresaHandler.RemoveEmpresa(context, empresa);
                return empresa;
            }
            catch (Exception)
            {
                return Ok(new { message = "Nao foi possivel remover a empresa" });
            }
        }
    }
}
