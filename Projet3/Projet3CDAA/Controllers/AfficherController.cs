using Projet3CDAA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet3CDAA.Controllers
{
    public class AfficherController : Controller
    {
        // GET: Afficher
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AfficherCode()
        {
            Magasin mag = Magasin.Instance;
            List<Produit> lst = new List<Produit>();
            ViewBag.Error = "0";
            string res = Request.QueryString["Recherche"];
            if (res != null && res != "")
            {
                int code = Int32.Parse(res);
                lst.Add(mag.ListProd.GetProduit(code));

                if (lst.Count == 0) ViewBag.Error = "1";
            }
            return View("AfficherCode", lst);
        }

        public ActionResult AfficherNom()
        {
            Magasin mag = Magasin.Instance;
            List<Produit> lst = new List<Produit>();
            ViewBag.Error = "0";
            string nom = Request.QueryString["Recherche"];
            if (nom != null && nom != "")
            {
                lst.Add(mag.ListProd.GetProduitNom(nom));

                if (lst.Count == 0) ViewBag.Error = "1";
            }
            return View("AfficherNom", lst);
        }

        public ActionResult AfficherCat()
        {
            Magasin mag = Magasin.Instance;
            List<Produit> lst = new List<Produit>();
            ViewBag.Error = "0";
            string res = Request.QueryString["Recherche"];
            if (res == "Consommable" || res == "NonConsommable")
            {
                Categorie cat = (Categorie)Enum.Parse(typeof(Categorie), res, false);
                lst = mag.ListProd.GetProdCategorie(cat);

                if (lst.Count == 0) ViewBag.Error = "1";
            }
            return View("AfficherCat", lst);
        }
    }
}