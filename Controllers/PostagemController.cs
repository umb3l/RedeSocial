using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedeSocial.Controllers
{
    public class PostagemController : Controller
    {
        // GET: Postagens
        public ActionResult Index()
        {
            return View();
        }
    }
}