using Introducao.Models;
using System;
using System.Collections.Generic;
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
            if(string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("", "O campo nome é obrigatório"); //primeiro parametro é a localização do campo para mostra a msg ao lado.
            }

            if (usuario.Senha != usuario.ConfirmarSenha)
            {
                ModelState.AddModelError("", "A senha deve ser igual a senha de confirmação"); //primeiro parametro é a localização do campo para mostra a msg ao lado.
            }

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
    }
}