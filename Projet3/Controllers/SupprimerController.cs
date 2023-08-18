using Projet3CDAA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet3CDAA.Controllers
{
    public class SupprimerController : Controller
    {
        // GET: Supprimer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Supprimer()
        {
            Magasin mag = Magasin.Instance;
            List<Produit> lst = new List<Produit>();
            ViewBag.Error = "0";
            string res = Request.QueryString["Supprime"];
            bool supr = false;
            if (res != null && res != "")
            {
                int code = Int32.Parse(res);
                lst.Add(mag.ListProd.GetProduit(code));

                if (lst.Count == 0)
                {
                    ViewBag.Error = "1";
                } else
                {
                    supr = true;
                }
                mag.ListProd.Supprime(lst[0]);
            }
            return View("Supprimer", supr);
        }
    }
}