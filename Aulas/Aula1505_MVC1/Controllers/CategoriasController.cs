using Aula1505_MVC1.Models;
using Aula1505_MVC1;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Aula1505_MVC1.Controllers
{
    public class CategoriasController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(

                new Categoria()
                {
                    Nome = "Casa"
                }

                );

            categorias.Add(new Categoria() { Nome = "Carro" });
            categorias.Add(new Categoria() { Nome = "Trabalho" });
            categorias.Add(new Categoria() { Nome = "Família" });


            ViewBag.MinhasCategorias = categorias;

            return View();
        }



        [HttpGet]
        public ActionResult Categoria(string nome, string descricao, bool ativo)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            //metodo para retornar os valores caso ocorra não ocorra o algum erro no cadastro de informações 
            return View(categoria);
        }
    }
}