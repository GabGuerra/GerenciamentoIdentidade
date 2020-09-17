using GerenciamentoIdentidade2.Models.Modulo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciamentoIdentidade2.Models
{
    public class PerfilVD
    {
        public string DscPerfil { get; set; }
        public int CodPerfil { get; set; }
        public List<ModuloVD> ListaModulos { get; set; }
        public List<ModuloVD> ListaModulosPermitidos { get; set; }
        public PerfilVD(string DscPerfil, int CodPerfil)
        {
            this.DscPerfil = DscPerfil;
            this.CodPerfil = CodPerfil;
        }
        public PerfilVD()
        {
            ListaModulos = new List<ModuloVD>();
            ListaModulosPermitidos = new List<ModuloVD>();            

        }

    }
}