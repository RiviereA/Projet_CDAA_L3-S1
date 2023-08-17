using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie1
{
    class LesMagasins
    {
        private List<Magasin> listMag;

        /// <summary>
        /// Constructeur par défaut de la classe LesMagasins
        /// </summary>
        public LesMagasins()
        {
            listMag = new List<Magasin>();
        }

        public List<Magasin> ListMag { get { return listMag; } }

        /// <summary>
        /// Méthode ajoutant un magasin à la liste des magasins
        /// </summary>
        /// <param name="mag">Magasin à ajouter</param>
        public void Ajoute(Magasin mag)
        {
            listMag.Add(mag);
        }

        /// <summary>
        /// Méthode supprimant un magasin de la liste des magasins
        /// </summary>
        /// <param name="mag">Magasin à supprimer</param>
        public void Supprime(Magasin mag)
        {
            if (listMag.Count>0) listMag.Remove(mag);
        }

        /// <summary>
        /// Méthode recherchant un magasin dans la liste des magasins à partir de son code
        /// </summary>
        /// <param name="id">Identifiant du magasin à chercher</param>
        /// <returns>Renvoie le magasin correspondant</returns>
        public Magasin GetMagasin(string id)
        {
            Magasin mag = null;
            foreach (Magasin m in listMag)
                if (m.IdMag == id) mag = m;
            return mag;
        }

        /// <summary>
        /// Méthode recherchant les magasins dans la liste des magasins contenant un certain produit
        /// </summary>
        /// <param name="code">Code du produit utiliser pour la recherche</param>
        /// <returns>Renvoie la liste des magasins contenant le produit</returns>
        public List<Magasin> GetMagasinParProduit(int code)
        {
            List<Magasin> lMag = new List<Magasin>();
            foreach (Magasin m in listMag)
                if (m.ListProd.GetProduit(code) != null) lMag.Add(m); ;
            return lMag;
        }

        /// <summary>
        /// Méthode renvoyant la description de chacun des magasins présent dans la liste des magasins
        /// </summary>
        /// <returns>Renvoie un chaîne de caractère contenant toutes les descriptions des magasins</returns>
        public override string ToString()
        {
            string s = "";

            foreach (Magasin m in listMag)
                s += "\n" + m.ToString();
            return s;
        }
    }
}
