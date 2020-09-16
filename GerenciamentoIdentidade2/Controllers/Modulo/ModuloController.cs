using GerenciamentoIdentidade2.Business;
using GerenciamentoIdentidade2.Models.Login;
using GerenciamentoIdentidade2.Models.Usuario;
using System.Web.Mvc;

namespace GerenciamentoIdentidade2.Controllers.Modulo
{
    public class ModuloController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("CadastroModuloIndex");
        }     
    }
}