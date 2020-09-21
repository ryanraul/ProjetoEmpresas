using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmpreasAPI.VisualObjects
{
    public class AtividadePrincipal
    {

        [Key]
        public int Id { get; set; }
        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        public string Text { get; set; }
        public string Code { get; set; }

    }
}
