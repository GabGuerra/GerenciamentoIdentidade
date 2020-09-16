using GerenciamentoIdentidade2.Models.Login;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.DataAcess
{
    public class LoginDAO
    {
        public MySqlDataReader BuscarDadosLogin(LoginVD login)
        {
            try
            {
                string strSql = @"SELECT 
	                                  U.NOME_USUARIO,
                                      U.CPF,
                                      L.*
                                  FROM
	                                  USUARIO U
                                  INNER JOIN LOGIN L ON U.CPF = L.CPF_USUARIO
                                  WHERE
	                                  L.SENHA = @SENHA
                                  AND L.EMAIL = @EMAIL";

                var conexaoBD = new Conexao();
                var conn = conexaoBD.ObterConexao();
                conn.Open();
                MySqlCommand sql = new MySqlCommand(strSql, conn);
                sql.Parameters.AddWithValue("@SENHA", login.Senha);
                sql.Parameters.AddWithValue("@EMAIL", login.Email);
                return sql.ExecuteReader();
            }
            catch
            {
                throw;
            }
        }
    }
}