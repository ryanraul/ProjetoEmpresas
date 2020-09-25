using EmpreasAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpreasAPI.Infrastructure.Queries
{
    public static class EmpresaQueries
    {
        private static readonly DataContext context = new DataContext();
        public static async Task<List<Empresa>> ListEmpresas()
        {
            var empresas = await context.Empresas
                .Include(x => x.AtividadePrincipal)
                .Include(x => x.AtividadesSecundarias)
                .Include(x => x.Qsa)
                .Include(x => x.Billing)
                .ToListAsync();
            return empresas;
        }

        public static async Task<Empresa> ListEmpresaId(int id)
        {
            var empresa = await ListEmpresas();
            return empresa.FirstOrDefault(x => x.Id == id);
        }

        public static async Task<Empresa> ListEmpresaCnpj(string cnpj)
        {
            var empresa = await ListEmpresas();
            return empresa.FirstOrDefault(x => x.Cnpj == cnpj);
        }

        public static async Task SaveAddedEmpresa(Empresa empresa)
        {
            context.Empresas.Add(empresa);
            await context.SaveChangesAsync();
        }

        public static async Task SaveRemovedEmpresa(Empresa empresa)
        {
            context.Empresas.Remove(empresa);
            await context.SaveChangesAsync();
        }

    }
}
