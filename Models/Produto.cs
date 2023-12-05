using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_final.Models
{
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Cód. Produto")]

        public int Id { get; set; }

        [Column("NomeProduto")]
        [Display(Name = "Nome")]
        public string NomeProduto { get; set; } = string.Empty;

        [Column("QuantidadeEstoque")]
        [Display(Name = "Quantidade no estoque")]

        public int QuantidadeEstoque { get; set; }

        [ForeignKey("TipoProdutoId")]
        public int TipoProdutoId { get; set; }
        public TipoProduto? TipoProduto { get; set; }

        [ForeignKey("FornecedorId")]
        public int FornecedorId { get; set; }

        public Fornecedor? Fornecedor { get; set;}
    }
}
