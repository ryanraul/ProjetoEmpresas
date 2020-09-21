using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmpreasAPI.Models
{
    public class Empresa
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string Cnpj { get; set; }
        public List<AtividadePrincipal> AtividadePrincipal { get; set; }
        public string DataSituacao { get; set; }
        public string Complemento { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<AtividadesSecundaria> AtividadesSecundarias { get; set; }
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
        public string Natureza_juridica { get; set; }
        public string Uf { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string Efr { get; set; }
        public string MotivoSituacao { get; set; }
        public string SituacaoEspecial { get; set; }
        public string DataSituacaoEspecial { get; set; }
        public string CapitalSocial { get; set; }
        public Billing Billing { get; set; }

    }
    public class AtividadePrincipal
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        //public virtual Empresa Empresa { get; set; }
        public string Text { get; set; }
        public string Code { get; set; }
    }

    public class AtividadesSecundaria
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        //public virtual Empresa Empresa { get; set; }
        public string Text { get; set; }
        public string Code { get; set; }
    }

    public class Qsa
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        //public virtual Empresa Empresa { get; set; }
        public string Qual { get; set; }
        public string Nome { get; set; }
        public string QualRepLegal { get; set; }
    }

    public class Billing
    {

        [Key]
        public int Id { get; set; }
        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        //public virtual Empresa Empresa { get; set; }
        public bool Free { get; set; }
        public bool Database { get; set; }
    }
}
