using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedeSocial.Controllers
{
    public class ComentarioController : Controller
    {
        // GET: Comentarios
        public ActionResult Index()
        {
            return View();
        }
    }
}