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
        public int Id { get; private set; }
        
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [JsonProperty("cnpj")]
        public string Cnpj { get; private set; }
        public string Complemento { get; private set; }
        public string Tipo { get; private set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public List<Qsa> Qsa { get; private set; }
        public string Situacao { get; private set; }
        public string Bairro { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Cep { get; private set; }
        public string Municipio { get; private set; }
        public string Fantasia { get; private set; }
        public string Porte { get; private set; }
        public string Abertura { get; private set; }
        public string Uf { get; private set; }
        public string Status { get; private set; }
        public string Message { get; private set; }
        public string Efr { get; private set; }
        public Billing Billing { get; private set; }
        public List<AtividadePrincipal> AtividadePrincipal { get; private set; }
        public List<AtividadesSecundaria> AtividadesSecundarias { get; private set; }
        public string DataSituacao { get; private set; }
        public DateTime UltimaAtualizacao { get; private set; }
        public string MotivoSituacao { get; private set; }
        public string NaturezaJuridica { get; private set; }
        public string SituacaoEspecial { get; private set; }
        public string DataSituacaoEspecial { get; private set; }
        public string CapitalSocial { get; private set; }
            
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
