using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.DataAcess
{
    public class Conexao
    {
        public MySqlConnection ObterConexao()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=AUTENTICACAO;uid=root;password=; convert zero datetime=True");
            return con;
        }
    }
}