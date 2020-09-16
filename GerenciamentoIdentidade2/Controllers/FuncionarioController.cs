using GerenciamentoIdentidade2.Business;
using GerenciamentoIdentidade2.Models;
using GerenciamentoIdentidade2.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciamentoIdentidade2.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        //Todo: retornar msg com validações / sucesso ao cadastrar
        public ActionResult InserirUsuario(FormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    FuncionarioVD usuario = new FuncionarioVD()
                    {
                        Nome = collection["nome"],
                        Cpf = collection["cpf"],
                        Perfil = new PerfilVD()
                        {
                            CodPerfil = Convert.ToInt32(collection["selCargo"])
                        }
                    };

                    new FuncionarioBL().InserirFuncionario(usuario);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
        public bool RetornaCheckboxCheckado(string valorCheckbox)
        {
            return Convert.ToBoolean(valorCheckbox.ToUpper().Equals("ON"));
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}