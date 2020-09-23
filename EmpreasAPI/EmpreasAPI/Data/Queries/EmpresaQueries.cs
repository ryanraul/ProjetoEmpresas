using EmpreasAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpreasAPI.Data.Queries
{
    public static class EmpresaQueries
    {
        public static async Task<List<Empresa>> ListaEmpresas(DataContext context)
        {
            var empresas = await context.Empresas
                .Include(x => x.AtividadePrincipal)
                .Include(x => x.AtividadesSecundarias)
                .Include(x => x.Qsa)
                .Include(x => x.Billing)
                .ToListAsync();
            return empresas;
        }
    }
}
