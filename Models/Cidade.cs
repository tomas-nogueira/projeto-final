using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_final.Models
{
    public class Cidade
    {
        [Column("Id")]
        [Display(Name = "Cód. da cidade")]

        public int Id { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Nome da cidade")]

        public string CidadeNome { get; set; } = string.Empty;

        [ForeignKey("EstadoId")]
        public int EstadoId { get; set; }

        public Estado? Estado { get; set; }
    }
}
