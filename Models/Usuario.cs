using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_final.Models
{
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Cód. do usuário")]

        public int Id { get; set; }

        [Column("NomeUsuario")]
        [Display(Name = "Nome do usuário")]

        public string NomeUsuario { get; set; } = string.Empty;

        [Column("EmailUsuario")]
        [Display(Name = "Email do usuário")]

        public string EmailUsuario { get; set; } = string.Empty;

        [Column("SenhaUsuario")]
        [Display(Name = "Senha do usuário")]

        public string SenhaUsuario { get; set; } = string.Empty;
    }
}
