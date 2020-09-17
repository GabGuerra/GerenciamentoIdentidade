using GerenciamentoIdentidade2.Models.Login;
using GerenciamentoIdentidade2.Models.Modulo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.DataAcess.Perfil
{
    public class CadastroPerfilDAO
    {
        //Implementar BaseDAO para commit/rollback 
        public MySqlDataReader ListarModulos()
        {
            try
            {
                string strSql = @"SELECT
                                    M.COD_MODULO,
                                    M.DSC_MODULO
                                  FROM
                                    MODULO M";
                var conexaoBD = new Conexao();
                var conn = conexaoBD.ObterConexao();
                conn.Open();
                MySqlCommand sql = new MySqlCommand(strSql, conn);
                return sql.ExecuteReader();
            }
            catch
            {
                throw;
            }
        }
    }
}