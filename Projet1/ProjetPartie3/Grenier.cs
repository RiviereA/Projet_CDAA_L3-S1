using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie3
{
    class Grenier
    {
        private Hashtable listAliment;

        /// <summary>
        /// Constructeur par défaut de la classe Grenier
        /// </summary>
        public Grenier()
        {
            this.listAliment = new Hashtable();
        }

        public Hashtable ListAliment { get { return listAliment; } }

        /// <summary>
        /// Méthode ajoutant un aliment au grenier
        /// </summary>
        /// <param name="a">Aliment à ajouter</param>
        public void Ajoute(Aliment a)
        {
            listAliment.Add(a.Numero, a);
        }

        /// <summary>
        /// Méthode modifiant un aliment existant en insérant un nouvel aliment à la place
        /// </summary>
        /// <param name="a">Nouvel aliment</param>
        public void Modifie(Aliment a)
        {
            listAliment.Remove(a.Numero);
            this.Ajoute(a);
        }

        /// <summary>
        /// Méthode supprimant un aliment du grenier
        /// </summary>
        /// <param name="cle">Clé de l'aliment à supprimer</param>
        public void Supprime(int cle)
        {
            listAliment.Remove(cle);
        }

        /// <summary>
        /// Méthode permettant la recherche d'un aliment dans la liste par sa clé
        /// </summary>
        /// <param name="cle">Clé de l'aliment recherché</param>
        /// <returns>Renvoie l'aliment recherché</returns>
        public Aliment Recherche(int cle)
        {
            return (Aliment)listAliment[cle];
        }

        /// <summary>
        /// Méthode renvoyant la description du grenier sous la forme d'une chaîne de caractère contenant la description de tous les aliments du grenier
        /// </summary>
        /// <returns>Renvoie la description du grenier</returns>
        public override string ToString()
        {
            string s = "";
            foreach (int c in listAliment.Keys)
                s += this.Recherche(c).ToString();
            return s;
        }

        /// <summary>
        /// Méthode ajoutant plusieurs aliments à la liste des aliments du grenier
        /// </summary>
        public void RemplirGrenier()
        {
            this.Ajoute(new Aliment(1, "Blé", "France N°1", 1.60));
            this.Ajoute(new Aliment(3, "Avoine", "Allemagne", 2.40));
            this.Ajoute(new Aliment(2, "Pomme de terre", "Belgique", 4.80));
        }
    }
}
