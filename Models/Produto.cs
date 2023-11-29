using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_final.Models
{
    public class Produto
    {
        [Column("ProdutoId")]
        [Display(Name = "Cód. Produto")]

        public int Id { get; set; }

        [Column("NomeProduto")]
        [Display(Name = "Nome")]

        public string NomeProduto { get; set; } = string.Empty;  
    }
}
