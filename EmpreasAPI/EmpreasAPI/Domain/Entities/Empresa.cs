using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EmpreasAPI.Domain.Entities
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string Cnpj { get; set; }
        public string Complemento { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Qsa> Qsa { get; set; }
        public string Situacao { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public string Fantasia { get; set; }
        public string Porte { get; set; }
        public string Abertura { get; set; }
        public string Uf { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string Efr { get; set; }
        public Billing Billing { get; set; }
        public List<AtividadePrincipal> AtividadePrincipal { get; set; }
        public List<AtividadesSecundaria> AtividadesSecundarias { get; set; }
        public string DataSituacao { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
        public string MotivoSituacao { get; set; }
        public string NaturezaJuridica { get; set; }
        public string SituacaoEspecial { get; set; }
        public string DataSituacaoEspecial { get; set; }
        public string CapitalSocial { get; set; }
            
        public Empresa() { }
        public Empresa(
            string cnpj, 
            string complemento, 
            string tipo, 
            string nome, 
            string telefone, 
            string email, 
            List<Qsa> qsa, 
            string situacao, 
            string bairro, 
            string logradouro, 
            string numero, 
            string cep, 
            string municipio, 
            string fantasia, 
            string porte, 
            string abertura, 
            string uf, 
            string status, 
            string message, 
            string efr, 
            Billing billing, 
            List<AtividadePrincipal> atividadePrincipal, 
            List<AtividadesSecundaria> atividadesSecundarias, 
            string dataSituacao,
            DateTime ultimaAtualizacao, 
            string motivoSituacao, 
            string naturezaJuridica, 
            string situacaoEspecial, 
            string dataSituacaoEspecial, 
            string capitalSocial
            )
        {
            Cnpj = cnpj;
            Complemento = complemento;
            Tipo = tipo;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Qsa = qsa;
            Situacao = situacao;
            Bairro = bairro;
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Municipio = municipio;
            Fantasia = fantasia;
            Porte = porte;
            Abertura = abertura;
            Uf = uf;
            Status = status;
            Message = message;
            Efr = efr;
            Billing = billing;
            AtividadePrincipal = atividadePrincipal;
            AtividadesSecundarias = atividadesSecundarias;
            DataSituacao = dataSituacao;
            UltimaAtualizacao = ultimaAtualizacao;
            MotivoSituacao = motivoSituacao;
            NaturezaJuridica = naturezaJuridica;
            SituacaoEspecial = situacaoEspecial;
            DataSituacaoEspecial = dataSituacaoEspecial;
            CapitalSocial = capitalSocial;
        }

        public string MostrarNome()
        {
            return Nome;
        }
    }

}
