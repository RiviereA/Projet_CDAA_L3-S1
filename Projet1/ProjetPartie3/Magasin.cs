using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie3
{
    class Magasin
    {
        private SortedList listProd;

        /// <summary>
        /// Constructeur par défaut de la classe Magasin
        /// </summary>
        public Magasin()
        {
            this.listProd = new SortedList();
        }
        
        public SortedList ListProd { get { return listProd; } }

        /// <summary>
        /// Méthode ajoutant un produit au magasin
        /// </summary>
        /// <param name="p">Produit à ajouter</param>
        public void Ajoute(Produit p)
        {
            listProd.Add(p.Code, p);
        }

        /// <summary>
        /// Méthode modifiant un produit existant en insérant un nouveau produit à la place
        /// </summary>
        /// <param name="p">Nouveau produit</param>
        public void Modifie(Produit p)
        {
            listProd.SetByIndex(listProd.IndexOfKey(p.Code), p);
        }

        /// <summary>
        /// Méthode supprimant un produit du magasin
        /// </summary>
        /// <param name="cle">Clé du produit à supprimer</param>
        public void Supprime(int cle)
        {
            listProd.Remove(cle);
        }

        /// <summary>
        /// Méthode permettant la recherche d'un produit dans la liste par sa clé
        /// </summary>
        /// <param name="cle">Clé du produit recherché</param>
        /// <returns>Renvoie le produit recherché</returns>
        public Produit Recherche(int cle)
        {
            return (Produit)listProd.GetByIndex(listProd.IndexOfKey(cle));
        }

        /// <summary>
        /// Méthode renvoyant la description du magasin sous la forme d'une chaîne de caractère contenant la description de tous les produits du magasin
        /// </summary>
        /// <returns>Renvoie la description du magasin</returns>
        public override string ToString()
        {
            string s = "";
            foreach(object c in listProd.GetKeyList())
                s += listProd.GetByIndex(listProd.IndexOfKey(c)).ToString();
            return s;
        }

        /// <summary>
        /// Méthode ajoutant plusieurs produits à la liste des produits du magasin
        /// </summary>
        public void RemplirMagasin()
        {
            this.Ajoute(new Produit(1,"Produit n°1",3.00,Categorie.Consommable,"Alimentaire"));
            this.Ajoute(new Produit(3, "Produit n°2", 5.00, Categorie.Consommable, "Outils"));
            this.Ajoute(new Produit(2, "Produit n°3", 7.00, Categorie.NonConsommable, "Mobilier"));
        }
    }
}
