﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projeto_final.Models
{
    public class Fornecedor
    {
        [Column("FornecedorId")]
        [Display(Name = "Cód. Fornecedor")]
        public int Id { get; set; }

        [Column("NomeFornecedor")]
        [Display(Name = "Nome")]

        public string NomeFornecedor { get; set; } = string.Empty;

        [Column("EmailFornecedor")]
        [Display(Name = "Nome")]

        public string EmailFornecedor { get; set; } = string.Empty;

        [Column("CnpjFornecedor")]
        [Display(Name = "Nome")]

        public string CnpjFornecedor { get; set; } = string.Empty;
    }
}
