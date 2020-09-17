using GerenciamentoIdentidade2.DataAcess.Perfil;
using GerenciamentoIdentidade2.Models;
using GerenciamentoIdentidade2.Models.Modulo;
using GerenciamentoIdentidade2.Models.Shared;
using GerenciamentoIdentidade2.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.Business.Perfil
{
    public class CadastroPerfilBL
    {
        //TODO: implementar Idisposable
        private CadastroPerfilDAO dao;
        public CadastroPerfilBL()
        {
            dao = new CadastroPerfilDAO();
        }

        public PerfilVD CadastroPerfilIndex()
        {
            PerfilVD perfil = new PerfilVD();

            // implementar trycatch
            //try
            //{  
            //}
            //catch (Exception ex)
            //{
            //}
            using (var dr = dao.ListarModulos())
            {
                while (dr.Read())
                {
                    perfil.ListaModulos.Add(new ModuloVD
                    {
                        CodModulo = Convert.ToInt32(dr["COD_MODULO"]),
                        NomeModulo = dr["DSC_MODULO"].ToString()
                    });
                }

            }         
            return perfil;
        }

    }
}