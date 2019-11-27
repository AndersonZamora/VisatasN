using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vistas.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuarip
        public ActionResult Lista()
        {
            return View();
        }
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Editar()
        {
            return View();
        }
    }
}