using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            usuario.Nome = "nome do usuário vindo da memória";

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            

            if (ModelState.IsValid)
            {

                return View("Resultado", usuario);
            }

            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }


        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "LoginFulano1",
                "LoginFulano2",
                "LoginFulano3",
                "LoginFulano4",
            }; // verificar se já existe o que for informado na tela

            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}