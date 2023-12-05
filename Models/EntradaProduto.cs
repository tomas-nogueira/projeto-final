using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projeto_final.Models
{
    public class EntradaProduto
    {
        [Column("Id")]
        [Display(Name = "Cód. da entrada do produto")]

        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }

        public Produto? Produto { get; set; }

        [Column("DataEntrada")]
        [Display(Name = "Data da entrada")]

        public DateTime DataEntrada { get; set; }

        [Column("QuantidadeEntrada")]
        [Display(Name = "Quantidade da entrada")]

        public int QuantidadeEntrada { get; set; }
    }
}
