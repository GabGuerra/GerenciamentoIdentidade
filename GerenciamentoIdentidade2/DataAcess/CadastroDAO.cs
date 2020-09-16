using GerenciamentoIdentidade2.Models.Usuario;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.DataAcess
{
    public class CadastroDAO
    {
        public void CriarConta(UsuarioGerenciamentoVD usuario)
        {
            var conexaoBD = new Conexao();
            var conn = conexaoBD.ObterConexao();
            conn.Open();

            var tran = conn.BeginTransaction();
            string strSql = @"INSERT INTO USUARIO
		                         (CPF,NOME_USUARIO)
	                         VALUES
		                         (@CPF,@NOME_USUARIO);
		                     
	                         INSERT INTO LOGIN
		                         (EMAIL,SENHA,CPF_USUARIO)
	                         VALUES
		                        (@EMAIL,@SENHA,@CPF_USUARIO);";

            MySqlCommand sql = new MySqlCommand(strSql, conn);


            sql.Parameters.AddWithValue("@CPF", usuario.Cpf);
            sql.Parameters.AddWithValue("@NOME_USUARIO", usuario.Nome);
            sql.Parameters.AddWithValue("@EMAIL", usuario.Login.Email);
            sql.Parameters.AddWithValue("@SENHA", usuario.Login.Senha);
            sql.Parameters.AddWithValue("@CPF_USUARIO", usuario.Cpf);

            sql.ExecuteNonQuery();
            tran.Commit();
            conn.Close();
        }
    }
}