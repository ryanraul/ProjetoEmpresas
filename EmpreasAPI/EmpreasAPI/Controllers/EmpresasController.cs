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
            var empresas = await context.Empresas.ToListAsync();
            if (empresas == null)
            {
                return NotFound(new { message = "Nenhuma empresa encontrada" });
            }
            return empresas;
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
                return BadRequest(new { message = "Cnpj ja Cadastrado" });
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
                        return NotFound(new { message = $"{data.Message}" });
                    }
                    else
                    {
                        data.Cnpj = model.Cnpj;
                        context.Empresas.Add(data);

                        //await context.SaveChangesAsync();
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
    }
}
