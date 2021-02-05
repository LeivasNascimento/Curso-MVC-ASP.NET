using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*  var pessoa = new Models.Pessoa();
              pessoa.Nome = "pessoa vindo do model";
              pessoa.Tipo = 2;

              return View(pessoa);*/

            var pessoa = new Models.Pessoa
            {
                PessoaId = 1,
                Nome = "Pessoa do model",
                Tipo = 1,
                Idade = 16
            };

            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;
            ViewBag.Idade = pessoa.Idade;

            return View(pessoa);
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Ajuda()
        {
            ViewBag.Message = "Leia as informações abaixo para tirar dúvidas.";
            return View();
        }

        public ActionResult Contatos()
        {
            return View();
        }
    }
}