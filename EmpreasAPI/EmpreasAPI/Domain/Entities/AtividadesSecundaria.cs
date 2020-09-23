using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EmpreasAPI.Domain.Entities
{
    public class AtividadesSecundaria
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        public string Text { get; set; }
        public string Code { get; set; }
    }
}
