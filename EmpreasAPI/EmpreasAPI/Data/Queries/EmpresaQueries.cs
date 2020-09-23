using EmpreasAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpreasAPI.Data.Queries
{
    public static class EmpresaQueries
    {
        private static readonly DataContext context = new DataContext();
        public static async Task<List<Empresa>> ListaEmpresas()
        {
            var empresas = await context.Empresas
                .Include(x => x.AtividadePrincipal)
                .Include(x => x.AtividadesSecundarias)
                .Include(x => x.Qsa)
                .Include(x => x.Billing)
                .ToListAsync();
            return empresas;
        }

        public static async Task<Empresa> ListaEmpresasId(int id)
        {
            var empresas = await ListaEmpresas();
            return empresas.FirstOrDefault(x => x.Id == id);
        }

        public static async Task<Empresa> ListaEmpresasCnpj(string cnpj)
        {
            var empresas = await ListaEmpresas();
            return empresas.FirstOrDefault(x => x.Cnpj == cnpj);
        }

        public static async Task SaveAddEmpresa(Empresa empresa)
        {
            context.Empresas.Add(empresa);
            await context.SaveChangesAsync();
        }

        public static async Task SaveRemoveEmpresa(Empresa empresa)
        {
            context.Empresas.Remove(empresa);
            await context.SaveChangesAsync();
        }

    }
}
