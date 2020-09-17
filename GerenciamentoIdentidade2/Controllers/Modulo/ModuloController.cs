using GerenciamentoIdentidade2.Business;
using GerenciamentoIdentidade2.Business.Modulo;
using GerenciamentoIdentidade2.Models.Login;
using GerenciamentoIdentidade2.Models.Modulo;
using GerenciamentoIdentidade2.Models.Usuario;
using System.Web.Mvc;

namespace GerenciamentoIdentidade2.Controllers.Modulo
{
    public class ModuloController : Controller
    {
        // GET: Login
        public ActionResult CadastroModuloIndex()
        {
            return View("CadastroModuloIndex");
        }

        public ActionResult InserirModulo(ModuloVD modulo)
        {
            //implementar using
            new ModuloBL().InserirModulo(modulo);
            return View("CadastroModuloIndex");
        }
    }
}