using GerenciamentoIdentidade2.DataAcess;
using GerenciamentoIdentidade2.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.Business
{
    public class FuncionarioBL
    {
        //TODO: implementar Idisposable
        private FuncionarioDAO dao;
        public FuncionarioBL()
        {
            dao = new FuncionarioDAO();
        }
        public void InserirFuncionario(FuncionarioVD usuario)
        {
            if (ValidarFuncionario(usuario))
                dao.InserirFuncionario(usuario);
        }

        public bool ValidarFuncionario(Pessoa usuario)
        {
            //Todo: validar campos do usuarioVD
            return true;
        }
    }
}