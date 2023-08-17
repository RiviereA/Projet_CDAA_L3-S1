using Projet3CDAA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet3CDAA.Controllers
{
    public class ListerController : Controller
    {
        // GET: Lister
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lister()
        {
            Magasin mag = Magasin.Instance;
            List<Produit> lst = mag.ListProd.ListProd;
            return View("Lister", lst);
        }
    }
}