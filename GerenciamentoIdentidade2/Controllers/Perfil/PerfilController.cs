using GerenciamentoIdentidade2.Business.Perfil;
using GerenciamentoIdentidade2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciamentoIdentidade2.Controllers
{
    public class PerfilController : Controller
    {
        public ActionResult CadastroPerfilIndex() 
        {
            return View("CadastroPerfilIndex", new CadastroPerfilBL().CadastroPerfilIndex());
        } 
    }
}