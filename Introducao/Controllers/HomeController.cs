using Introducao.Models;
using System;
using System.Collections.Generic;
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

        [HttpPost]
        public ActionResult Lista(int PessoaId, string Nome, string Tipo)
        {
            //poderia montar uma lista de pessoas do banco de dados e enviaria para a view Lista e assim varreria essa lista e mostraria a lista 
            //na tela; o exemplo abaixo é montando a lista do banco porém pode ser necessário obter esses dados da tela.

            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa pessoa1 = new Pessoa
            {
                PessoaId = 1,
                Idade = 20,
                Nome = "Fulano 1",
                Tipo = 1
            };

            Pessoa pessoa2 = new Pessoa
            {
                PessoaId = 2,
                Idade = 22,
                Nome = "Fulano 2",
                Tipo = 1
            };


            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);

            ViewBag.Pessoas = pessoas;


            // exemplo obtendo os dados da tela:

            Pessoa pessoaTela = new Pessoa
            {
                PessoaId = PessoaId,
                Nome = Nome,
                Tipo = !string.IsNullOrEmpty(Tipo) ? Convert.ToInt32(Tipo) : 1
            };



            return View(pessoaTela);
        }

        public ActionResult ListaComFormCollection(FormCollection form)
        {
            Pessoa pessoaDaTelaPegandoOsCamposDePessoaDaPropriedadeName = new Pessoa
            {
                PessoaId = Convert.ToInt32(form["PessoaId"]),
                Nome = form["Nome"],
                Tipo = !string.IsNullOrEmpty(form["Tipo"]) ? Convert.ToInt32(form["Tipo"]) : 1

            };

            return View(pessoaDaTelaPegandoOsCamposDePessoaDaPropriedadeName);
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