using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Projeto_final.Models
{
    public class TipoProduto
    {
        [Column("Id")]
        [Display(Name = "Cód. do tipo de produto")]

        public int Id { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "Descrição do tipo de produto")]

        public string TipoProdutoDescricao { get; set; } = string.Empty;
    }
}
