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
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Empresa>>> Get([FromServices] DataContext context)
        {
            var empresas = await context.Empresas
                .Include(x=>x.Atividade_principal)
                .Include(x=>x.atividades_secundarias)
                .Include(x=>x.qsa)
                .Include(x=>x.billing)
                .ToListAsync();
            if (!empresas.Any())
            {
                return Ok(new { message = "Nenhuma empresa encontrada" });
            }
            return empresas;
        }

        [HttpGet]
        [Route("Cnpj/{cnpj}")]
        public async Task<ActionResult<Empresa>> GetByCnpj(
            [FromServices] DataContext context,
            string cnpj)
        {
            var empresa = await context.Empresas
                .Include(x=>x.Atividade_principal)
                .Include(x=>x.atividades_secundarias)
                .Include(x=>x.qsa)
                .Include(x=>x.billing)
                .FirstOrDefaultAsync(x=>x.Cnpj == cnpj);
            if(empresa == null)
            {
                return Ok(new { message = "Empresa nao encontrada" });
            }
            return empresa;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Empresa>> GetById(
            [FromServices] DataContext context,
            int id)
        {
            var empresa = await context.Empresas
                .Include(x=>x.Atividade_principal)
                .Include(x=>x.atividades_secundarias)
                .Include(x=>x.qsa)
                .Include(x=>x.billing)
                .FirstOrDefaultAsync(x => x.Id == id);

            if(empresa == null)
            {
                return Ok(new { message = "Empresa nao encontrada" });
            }
            return empresa;
        }
        
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Empresa>> Post(
            [FromServices] DataContext context,
            [FromBody] Empresa model)
        {
            var verif_cnpj = await context.Empresas.FirstOrDefaultAsync(x => x.Cnpj == model.Cnpj);
            if (verif_cnpj != null)
            {
                return Ok(new { message = "Cnpj ja Cadastrado" });
            }

            if (ModelState.IsValid)
            {
                var httpClient = HttpClientFactory.Create();
                var url = $"https://www.receitaws.com.br/v1/cnpj/{model.Cnpj}";
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

                if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                {
                    var content = httpResponseMessage.Content;
                    var data = await content.ReadAsAsync<Empresa>();
                    if(data.status != "OK")
                    {
                        return Ok(new { message = $"{data.Message}" });
                    }
                    else
                    {
                        data.Cnpj = model.Cnpj;
                        context.Empresas.Add(data);

                        await context.SaveChangesAsync();
                        return data;
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
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
            var empresa = await context.Empresas.FirstOrDefaultAsync(x => x.Id == id);
            if(empresa == null)
            {
                return Ok(new { message = "Empresa nao encontrada!" });
            }

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
