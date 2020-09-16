using GerenciamentoIdentidade2.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.Models.Usuario
{
    public class UsuarioGerenciamentoVD : Pessoa
    {
        public LoginVD Login { get; set; }

        public UsuarioGerenciamentoVD()
        {
            Login = new LoginVD();
        }
    }
}