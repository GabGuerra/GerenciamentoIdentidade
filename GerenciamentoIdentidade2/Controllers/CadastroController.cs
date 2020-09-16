using GerenciamentoIdentidade2.Business;
using GerenciamentoIdentidade2.Models.Login;
using GerenciamentoIdentidade2.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciamentoIdentidade2.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("CadastroIndex");
        }

        public ActionResult CriarConta(FormCollection form)
        {
            UsuarioGerenciamentoVD usuario = new UsuarioGerenciamentoVD
            {
                Nome = form["inputNomeCadastro"],
                Cpf = form["inputCpfCadastro"],
                Login = new LoginVD(form["inputSenhaCadastro"], form["inputEmailCadastro"])
            };

            //TODO: retornar respostas do servidor e tratar no front.
            /*return*/
            new CadastroBL().CriarConta(usuario);

            return RedirectToAction("IndexLogin", "Login");
        }

    }
}