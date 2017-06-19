using Projeto.Web.BootGrid.AcessoDados;
using Projeto.Web.BootGrid.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Linq.Dynamic;

namespace Projeto.Web.BootGrid.Controllers
{
    public class HomeController : Controller
    {

        private LivroContexto db = new LivroContexto();

        // GET: Home
        public ActionResult Index()
        {
            TempData["NomeControle"] = "Home";
            return View();
        }

        //parando aula 6

        //listagem de dados
        public JsonResult ListarDadosGrid(string searchPhrase, int current = 1, int rowCount = 10)
        {
            //sort[Titulo] || sort[]
            string chave = Request.Form.AllKeys.Where(k => k.StartsWith("sort")).First();
            string ordenacao = Request[chave];
            string campo = chave.Replace("sort[", string.Empty).Replace("]", string.Empty);

            var DadosBusca = db.Livros.AsQueryable();
            int totalRegistros = DadosBusca.Count();


            if (!string.IsNullOrWhiteSpace(searchPhrase))
            {
                // tentar converter em número para pesquisa
                int ano = 0;
                int.TryParse(searchPhrase, out ano);

                // tentar converter em décima para pesquisa
                decimal valor = 0.0m;
                decimal.TryParse(searchPhrase, out valor);

                // utiliza Dynamic LINQ para fazer o filtro
                DadosBusca = DadosBusca.Where("Titulo.Contains(@0) OR Autor.Contains(@0) OR AnoEdicao == @1 OR Valor == @2", searchPhrase, ano, valor);
            }


            string campoOrdenacao = string.Format("{0} {1}", campo, ordenacao);

            // utiliza Dynamic LINQ para fazer o ordenamento por um campo
            var RegistrosPaginados = DadosBusca.OrderBy(campoOrdenacao).Skip((current - 1) * rowCount).Take(rowCount);

            int totalPaginados = RegistrosPaginados.Count();

            return Json(
                    new
                    {
                        rows = RegistrosPaginados.ToList(),
                        current = current,
                        rowCount = rowCount,
                        total = totalRegistros
                    },
                    JsonRequestBehavior.AllowGet);

        }

        public JsonResult listar()
        {
            try
            {
                var livros = db.Livros.Include(listar => listar.Genero.ToString());
                return Json(livros.ToList(), JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                return Json(new { mensagem = "O Livro cadastrado não foi encontrado" }, JsonRequestBehavior.AllowGet);
            }

        }



        public ActionResult Detalhe(int? id)
        {
            return View();
        }


        public ActionResult Editar(int? id)
        {
            return View();
        }

        public ActionResult Excluir(int? id)
        {
            return View();
        }




    }
}