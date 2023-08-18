using Projet3CDAA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet3CDAA.Controllers
{
    public class AjouterController : Controller
    {
        // GET: Ajouter
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ajouter()
        {
            return View("Ajouter", new Produit());
        }

        [HttpPost]
        public ActionResult Ajouter(Produit p)
        {
            Magasin mag = Magasin.Instance;
            mag.ListProd.Ajoute(p);
            return RedirectToAction("Afficher","Afficher","Afficher");
        }
    }
}