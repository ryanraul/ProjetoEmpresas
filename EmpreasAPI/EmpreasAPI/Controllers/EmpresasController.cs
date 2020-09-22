using EmpreasAPI.Data;
using EmpreasAPI.Models;
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

        public async Task<List<Empresa>> ListaEmpresas(DataContext context)
        {
            var empresas = await context.Empresas
                .Include(x => x.AtividadePrincipal)
                .Include(x => x.AtividadesSecundarias)
                .Include(x => x.Qsa)
                .Include(x => x.Billing)
                .ToListAsync();
            return empresas;
        }

        public async Task<ActionResult<Empresa>> RequisicaoWebService(string cnpj)
        {
            var httpClient = HttpClientFactory.Create();
            var url = $"https://www.receitaws.com.br/v1/cnpj/{cnpj}";
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var data = await content.ReadAsAsync<Empresa>();
                if (data.Status != "OK")
                {
                    return Ok(new { message = $"{data.Message}" });
                }
                return data;
            }
            else
            {
                return Ok(new { message = $"Aguarde um pouco ate o proximo registro (Erro: {httpResponseMessage.StatusCode})" });
            }
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Empresa>>> Get([FromServices] DataContext context)
        {
            var empresas = await ListaEmpresas(context);

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
            var empresas = await ListaEmpresas(context);
            var empresa  = empresas.FirstOrDefault(x=> x.Cnpj == cnpj);

            return VerificarEmpresa(empresa);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Empresa>> GetById(
            [FromServices] DataContext context,
            int id)
        {

            var empresas = await ListaEmpresas(context);
            var empresa = empresas.FirstOrDefault(x => x.Id == id);

            return VerificarEmpresa(empresa);
        }
        
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Empresa>> Post(
            [FromServices] DataContext context,
            [FromBody] Empresa model)
        {
            var verificarCnpj = await context.Empresas.FirstOrDefaultAsync(x => x.Cnpj == model.Cnpj);
            if (verificarCnpj != null)
                return Ok(new { message = "Cnpj ja Cadastrado" });


            if (ModelState.IsValid)
            {

                var data = await RequisicaoWebService(model.Cnpj);
                if (data.Result == null)
                {
                    data.Value.Cnpj = model.Cnpj;
                    context.Empresas.Add(data.Value);
                    await context.SaveChangesAsync();
                }
                return data;
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

            var empresas = await ListaEmpresas(context);
            var empresa = empresas.FirstOrDefault(x => x.Id == id);

            if (empresa == null)
                return Ok(new { message = "Empresa nao encontrada!" });

            try
            {
                context.Empresas.Remove(empresa);
                await context.SaveChangesAsync();
                return empresa;
            }
            catch (Exception)
            {
                return Ok(new { message = "Nao foi possivel remover a empresa" });
            }
        }
    }
}
