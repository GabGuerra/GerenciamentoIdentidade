using GerenciamentoIdentidade2.Models.Login;
using GerenciamentoIdentidade2.Models.Modulo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.DataAcess.Modulo
{
    public class ModuloDAO
    {
        //Implementar BaseDAO para commit/rollback 
        public void InserirModulo(ModuloVD modulo)
        {            
            try
            {
                string strSql = @"INSERT INTO MODULO(DSC_MODULO) VALUES(@DSC_MODULO)";

                var conexaoBD = new Conexao();
                var conn = conexaoBD.ObterConexao();
                conn.Open();
                MySqlCommand sql = new MySqlCommand(strSql, conn);
                sql.Parameters.AddWithValue("@DSC_MODULO", modulo.NomeModulo);
                var tran =  conn.BeginTransaction();
                sql.ExecuteNonQuery();
                tran.Commit();
            }
            catch
            {                
                throw;
            }
        }
    }
}