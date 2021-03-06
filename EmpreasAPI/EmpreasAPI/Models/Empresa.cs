﻿using EmpreasAPI.VisualObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EmpreasAPI.Models
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

        [JsonProperty("atividade_principal")]
        public List<AtividadePrincipal> AtividadePrincipal { get; set; }

        [JsonProperty("atividades_secundarias")]
        public List<AtividadesSecundaria> AtividadesSecundarias { get; set; }

        [JsonProperty("data_situacao")]
        public string DataSituacao { get; set; }

        [JsonProperty("ultima_atualizacao")]
        public DateTime UltimaAtualizacao { get; set; }

        [JsonProperty("motivo_situacao")]
        public string MotivoSituacao { get; set; }

        [JsonProperty("natureza_juridica")]
        public string NaturezaJuridica { get; set; }

        [JsonProperty("situacao_especial")]
        public string SituacaoEspecial { get; set; }

        [JsonProperty("data_situacao_especial")]
        public string DataSituacaoEspecial { get; set; }

        [JsonProperty("capital_social")]
        public string CapitalSocial { get; set; }
      
    }

}
