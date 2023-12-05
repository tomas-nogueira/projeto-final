using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projeto_final.Models
{
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Cód. do estado")]

        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Nome do estado")]

        public string EstadoNome { get; set; } = string.Empty;

        [ForeignKey("PaisId")]
        public int PaisId { get; set; } 

        public Pais? Pais { get; set; }
    }
}
