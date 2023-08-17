using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie1
{
    class LesProduits
    {
        private List<Produit> listProd;

        /// <summary>
        /// Constructeur par défaut de la classe LesProduits
        /// </summary>
        public LesProduits()
        {
            listProd = new List<Produit>();
        }
        
        public List<Produit> ListProd { get { return listProd; } }

        /// <summary>
        /// Méthode ajoutant un produit à la liste des produits
        /// </summary>
        /// <param name="prod">Produit à ajouter</param>
        public void Ajoute(Produit prod)
        {
            listProd.Add(prod);
        }

        /// <summary>
        /// Méthode supprimant un produit de la liste des produits
        /// </summary>
        /// <param name="prod">Produit à supprimer</param>
        public void Supprime(Produit prod)
        {
            if (listProd.Count>0) listProd.Remove(prod);
        }

        /// <summary>
        /// Méthode renvoyant la description de chacun des produits présent dans la liste des produits
        /// </summary>
        /// <returns>Renvoie un chaîne de caractère contenant toutes les descriptions des produits</returns>
        public override string ToString()
        {
            string s = "";

            foreach (Produit p in listProd)
                s += "\n" + p.ToString();
            return s;
        }

        /// <summary>
        /// Méthode recherchant un produit dans la liste des produist à partir de son code
        /// </summary>
        /// <param name="c">Code du produit à chercher</param>
        /// <returns>Renvoie le produit correspondant</returns>
        public Produit GetProduit(int c)
        {
            Produit prod = null;
            foreach (Produit p in listProd)
                if (p.Code == c) prod = p;
            return prod;
        }

        /// <summary>
        /// Méthode recherchant un produit dans la liste des produits à partir de son indice dans la liste
        /// </summary>
        /// <param name="i">Indice du produit à chercher</param>
        /// <returns>Renvoie le produit correspondant</returns>
        public Produit GetProduitIndice(int i)
        {
            return listProd.GetRange(i, 1).First();
        }

        /// <summary>
        /// Méthode recherchant les produits dans la liste des produits appartenant à une certaine catégorie
        /// </summary>
        /// <param name="cat">Catégorie des produits à chercher</param>
        /// <returns>Renvoie la liste des produits correspondant</returns>
        public List<Produit> GetProdCategorie(Categorie cat)
        {
            List<Produit> lst = new List<Produit>();
            foreach (Produit p in listProd)
                if (p.Cat == cat)
                    lst.Add(p);
            return lst;
        }

        /// <summary>
        /// Méthode recherchant les produits dans la liste des produits appartenant à une certaine sous-catégorie
        /// </summary>
        /// <param name="sc">Sous-catégorie des produits à chercher</param>
        /// <returns>Renvoie la liste des produits correspondant</returns>
        public List<Produit> GetProduitSousCat(string sc)
        {
            List<Produit> lst = new List<Produit>();
            foreach (Produit p in listProd)
                if (p.SousCat == sc)
                    lst.Add(p);
            return lst;
        }

        /// <summary>
        /// Méthode renvoyant la liste des produits trié par leur code
        /// </summary>
        /// <returns>Renvoie la liste trié des produits</returns>
        public List<Produit> TriProd()
        {
            List<Produit> listeTrie = new List<Produit>();
            Produit[] listeTemp = listProd.ToArray();
            Produit temp;

            while (listeTrie.Count() < this.listProd.Count())
            {
                temp = new Produit();
                for (int i = 0; i < listeTemp.Count(); i++)
                {
                    if ((temp.Code == -1) && (listeTrie.Contains(listeTemp[i]) == false))
                    {
                        temp = listeTemp[i];
                    }
                    else if ((listeTemp[i].CompareTo(temp) < 0) && (listeTrie.Contains(listeTemp[i]) == false)) temp = listeTemp[i];
                }
                listeTrie.Add(temp);
            }
            return listeTrie;
        }

        /// <summary>
        /// Méthode renvoyant la liste des produits à risque
        /// </summary>
        /// <returns>Renvoie la liste des produits à risque</returns>
        public List<Produit> ListePAR()
        {
            List<Produit> liste = new List<Produit>();

            foreach (Produit p in listProd)
            {
                if ((p.ToString().Contains("Type : ")) && (p.ToString().Contains("Regles : "))) liste.Add(p);
            }

            return liste;
        }
    }
}
