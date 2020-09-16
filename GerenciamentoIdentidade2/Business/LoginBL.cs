using GerenciamentoIdentidade2.DataAcess;
using GerenciamentoIdentidade2.Models.Login;
using GerenciamentoIdentidade2.Models.Shared;
using GerenciamentoIdentidade2.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.Business
{
    public class LoginBL
    {
        //TODO: implementar Idisposable
        private LoginDAO dao;
        public LoginBL()
        {
            dao = new LoginDAO();
        }
        public ResultadoVD Login(LoginVD login)
        {
            ResultadoVD resultado = new ResultadoVD(true);
            try
            {
                using (var dr = dao.BuscarDadosLogin(login))
                {
                    if (dr.Read())
                    {
                        UsuarioGerenciamentoVD usuario = new UsuarioGerenciamentoVD
                        {
                            Cpf = dr["CPF"].ToString(),
                            Nome = dr["NOME_USUARIO"].ToString(),
                            Login = login
                        };
                        resultado.Resultado = usuario;
                    }
                    else
                        resultado.Sucesso = false;
                }
            }
            catch (Exception ex)
            {
                resultado.Mensagem = ex.Message;
                resultado.Sucesso = false;
            }

            return resultado;
        }
    }
}