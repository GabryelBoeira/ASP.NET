using Aula2205_Entidy.Models;
using Aula2205_Entidy.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Aula2205_Entidy.Controllers
{
    public class UsuariosController : Controller
    {
       

        // GET: Usuarios
        public ActionResult Index()
        {
            MeuContexto contexto = new MeuContexto();
            List<Usuario> usuario = new MeuContexto.ToList();

            return View();
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario) {
            if (ModelState.IsValid) {
                MeuContexto contexto = new MeuContexto();
                contexto.Usuarios.Add(usuario);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        public ActionResult Details(int? id) {

            //verifiaca se o id estiver nulo 
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            MeuContexto contexto = new MeuContexto();

            Usuario usu = contexto.Usuarios.Find(id);
            if (usu == null) {
                return HttpNotFound();
            }
            return View(usu);
        }


    }
}