using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpreasAPI.Domain.Entities
{
    public class Billing
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        public bool Free { get; set; }
        public bool Database { get; set; }
    }
}
