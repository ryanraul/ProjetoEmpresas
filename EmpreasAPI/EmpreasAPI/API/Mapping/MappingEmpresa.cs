using EmpreasAPI.Domain.Entities;
using EmpreasAPI.Domain.Models;


namespace EmpreasAPI.API.Mapping
{
    public static class MappingEmpresa
    {
        public static Empresa MappingEmpresaWStoEmpresa(EmpresaWS empresa)
        {
            return new Empresa
            (
                empresa.Cnpj,
                empresa.Complemento,
                empresa.Tipo,
                empresa.Nome,
                empresa.Telefone,
                empresa.Email,
                empresa.Qsa,
                empresa.Situacao,
                empresa.Bairro,
                empresa.Logradouro,
                empresa.Numero,
                empresa.Cep,
                empresa.Municipio,
                empresa.Fantasia,
                empresa.Porte,
                empresa.Abertura,
                empresa.Uf,
                empresa.Status,
                empresa.Message,
                empresa.Efr,
                empresa.Billing,
                empresa.AtividadePrincipal,
                empresa.AtividadesSecundarias,
                empresa.DataSituacao,
                empresa.UltimaAtualizacao,
                empresa.MotivoSituacao,
                empresa.NaturezaJuridica,
                empresa.SituacaoEspecial,
                empresa.DataSituacaoEspecial,
                empresa.CapitalSocial
            );
        }
    }
}
