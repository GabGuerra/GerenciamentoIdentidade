using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.Models.Usuario
{
    public class Pessoa
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
    }
}