using EmpreasAPI.Data;
using EmpreasAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            if (ModelState.IsValid)
            {
                context.Empresas.Add(model);
                //await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
