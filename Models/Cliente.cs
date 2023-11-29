using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projeto_final.Models
{
    public class Cliente
    {
        [Column("ClienteId")]
        [Display(Name = "Cód. Cliente")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do Cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data de nascimento")]

        public DateTime DataNascimento { get; set; }

        [Column("CpfCliente")]
        [Display(Name = "CPF")]

        public string CpfCliente { get; set; } = string.Empty;

        [Column("EnderecoCliente")]
        [Display(Name = "Endereço")]

        public string EnderecoCliente { get; set; } = string.Empty;

        [Column("NumeroCasaCliente")]
        [Display(Name = "Número da casa")]
        public string NumeroCasaCliente { get; set; } = string.Empty;

        [Column("BairroCliente")]
        [Display(Name = "BairroCliente")]

        public string BairroCliente { get; set; } = string.Empty;

        [Column("Cidadeid")]
        [Display(Name = "Cidade")]

        public int CidadeId { get; set; }

        [Column("TelefoneCelular")]
        [Display(Name = "Telefone Celular")]

        public string TelefoneCelular { get; set; } = string.Empty;
    }
}

