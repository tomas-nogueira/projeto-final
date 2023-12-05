using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projeto_final.Models
{
    public class SaidaProduto
    {
        [Column("Id")]
        [Display(Name = "Cód. da saída do produto")]

        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }

        public Produto? Produto { get; set; }

        [Column("DataSaida")]
        [Display(Name = "Data da saída")]

        public DateTime DataSaida { get; set; }

        [Column("QuantidadeSaida")]
        [Display(Name = "Quantidade da saída")]

        public int QuantidadeSaida { get; set; }

        // UsuarioId

        [ForeignKey("ClienteId")]

        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        [ForeignKey("TipoSaidaId")]
        public int TipoSaidaId { get; set; }

       public TipoSaida? TipoSaida { get; set; }
    }
}
