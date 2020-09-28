using EmpreasAPI.Domain.Entities;
using EmpreasAPI.Infrastructure.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmpreasAPI.Domain.Repository
{
    public class EmpresaRepository
    {
        public async Task<List<Empresa>> GetEmpresas()
        {
            return await EmpresaQueries.ListEmpresas();
        }

        public async Task<Empresa> GetEmpresaCnpj(string cnpj)
        {
            return await EmpresaQueries.ListEmpresaCnpj(cnpj);
        }

        public async Task<Empresa> GetEmpresaId(int id)
        {
            return await EmpresaQueries.ListEmpresaId(id);
        }

        public async Task AddEmpresa(Empresa empresa)
        {
            await EmpresaQueries.SaveAddedEmpresa(empresa);
        }

        public async Task RemoveEmpresa(Empresa empresa)
        {
            await EmpresaQueries.SaveRemovedEmpresa(empresa);
        }
    }
}
