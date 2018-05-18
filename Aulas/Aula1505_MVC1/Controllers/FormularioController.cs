using Aula1505_MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1505_MVC1.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult Index()
        {
            return View();


        }
        [HttpPost]
        public ActionResult Formulario(string nome, string descricao, bool ativo) {
            return View();
        }

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