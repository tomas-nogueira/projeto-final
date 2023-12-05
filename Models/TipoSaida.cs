using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projeto_final.Models
{
    public class TipoSaida
    {
        [Column("Id")]
        [Display(Name = "Cód. do tipo da saída do produto")]

        public int Id { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "Tipo da saida descrição")]

        public string TipoSaidaDescricao { get; set; } = string.Empty;
    }
}