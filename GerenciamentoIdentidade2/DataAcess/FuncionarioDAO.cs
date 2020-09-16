using GerenciamentoIdentidade2.Models.Usuario;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.DataAcess
{
    public class FuncionarioDAO
    {
        public void InserirFuncionario(FuncionarioVD func)
        {
            var conexaoBD = new Conexao();
            var conn = conexaoBD.ObterConexao();
            conn.Open();

            var tran = conn.BeginTransaction();
            string strSql = @"INSERT INTO FUNCIONARIO
	                            (CPF, NOME_FUNCIONARIO, COD_PERFIL)
                              VALUES
	                            (@CPF, @NOME_FUNCIONARIO, @COD_PERFIL)";

            MySqlCommand sql = new MySqlCommand(strSql, conn);


            sql.Parameters.AddWithValue("@CPF", func.Cpf);
            sql.Parameters.AddWithValue("@NOME_FUNCIONARIO", func.Nome);
            sql.Parameters.AddWithValue("@COD_PERFIL", func.Perfil.CodPerfil);

            sql.ExecuteNonQuery();
            tran.Commit();
            conn.Close();
        }
    }
}