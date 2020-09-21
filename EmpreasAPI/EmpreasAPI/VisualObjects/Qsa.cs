using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpreasAPI.VisualObjects
{
    public class Qsa
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        public string Qual { get; set; }
        public string Nome { get; set; }
        public string QualRepLegal { get; set; }
    }
}
