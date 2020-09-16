using GerenciamentoIdentidade2.DataAcess;
using GerenciamentoIdentidade2.Models.Shared;
using GerenciamentoIdentidade2.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.Business
{
    public class CadastroBL
    {
        //TODO: implementar Idisposable
        private CadastroDAO dao;
        public CadastroBL()
        {
            dao = new CadastroDAO();
        }

        public ResultadoVD CriarConta(UsuarioGerenciamentoVD usuario)
        {
            ResultadoVD resultado = new ResultadoVD(true);

            try
            {
                dao.CriarConta(usuario);
            }
            catch (Exception ex)
            {
                resultado.Sucesso = false;
                resultado.Mensagem = $"Não foi possível criar a conta. {Environment.NewLine} {ex.Message}";
            }

            return resultado;
        }

    }
}