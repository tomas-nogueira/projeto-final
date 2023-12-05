using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projeto_final.Models
{
    public class Pais
    {
        [Column("Id")]
        [Display(Name = "Cód. do país")]

        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name = "Nome do país")]

        public string PaisNome { get; set; } = string.Empty;
    }
}
