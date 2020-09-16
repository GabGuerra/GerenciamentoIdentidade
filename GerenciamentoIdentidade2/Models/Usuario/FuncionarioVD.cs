using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.Models.Usuario
{
    public class FuncionarioVD : Pessoa
    {
        public PerfilVD Perfil { get; set; }
    }
}