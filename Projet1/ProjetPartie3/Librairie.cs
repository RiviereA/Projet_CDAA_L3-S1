using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie3
{
    class Librairie
    {
        private Dictionary<string, Livre> listLivre;

        /// <summary>
        /// Constructeur par défaut de la classe Librairie
        /// </summary>
        public Librairie()
        {
            this.listLivre = new Dictionary<string, Livre>();
        }

        public Dictionary<string, Livre> ListLivre { get { return listLivre; } }

        /// <summary>
        /// Méthode ajoutant un livre à la librairie
        /// </summary>
        /// <param name="l">Livre à ajouter</param>
        public void Ajoute(Livre l)
        {
            listLivre.Add(l.Id, l);
        }

        /// <summary>
        /// Méthode modifiant un livre existant en insérant un nouveau livre à la place
        /// </summary>
        /// <param name="l">Nouveau livre</param>
        public void Modifie(Livre l)
        {
            listLivre.Remove(l.Id);
            this.Ajoute(l);
        }

        /// <summary>
        /// Méthode triant les livres de la librairie par leur clé
        /// La méthode de tri utilisé est celle du tri par sélection
        /// </summary>
        public void Tri()
        {
            Dictionary<string, Livre> listTemp = new Dictionary<string, Livre>(listLivre);
            List<string> listeKey = new List<string>();
            Dictionary<string, Livre> liste = new Dictionary<string, Livre>();
            string cle;
            int i = 0;

            while (i < listLivre.Count)
            {
                cle = listTemp.Keys.Min();
                foreach (string c in listTemp.Keys)
                {
                    if (cle.CompareTo(c) > 0)
                    {
                        cle = c;
                    }
                }
                listeKey.Add(cle);
                listTemp.Remove(cle);
                i++;
            }

            foreach (string c in listeKey)
            {
                liste.Add(c, this.Recherche(c));
            }
            listLivre = liste;
        }

        /// <summary>
        /// Méthode supprimant un livre de la librairie
        /// </summary>
        /// <param name="cle">Clé du livre à supprimer</param>
        public void Supprime(string cle)
        {
            listLivre.Remove(cle);
        }

        /// <summary>
        /// Méthode permettant la recherche d'un livre dans la liste par sa clé
        /// </summary>
        /// <param name="cle">Clé du livre recherché</param>
        /// <returns>Renvoie le livre recherché</returns>
        public Livre Recherche(string cle)
        {
            Livre temp = new Livre();
            listLivre.TryGetValue(cle, out temp);
            return temp;
        }

        /// <summary>
        /// Méthode renvoyant la description du librairie sous la forme d'une chaîne de caractère contenant la description de tous les livres de la librairie
        /// </summary>
        /// <returns>Renvoie la description du librairie</returns>
        public override string ToString()
        {
            string s = "";
            foreach (string c in listLivre.Keys)
                s += this.Recherche(c).ToString();
            return s;
        }

        /// <summary>
        /// Méthode ajoutant plusieurs livres à la liste des livres de la librairie
        /// </summary>
        public void RemplirLibrairie()
        {
            this.Ajoute(new Livre("1","Livre N°1","Auteur N°1",10.00));
            this.Ajoute(new Livre("3", "Livre N°2", "Auteur N°2", 15.00));
            this.Ajoute(new Livre("2", "Livre N°3", "Auteur N°3", 17.50));
        }
    }
}
