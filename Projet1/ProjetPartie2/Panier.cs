using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie2
{
    class Panier<T> where T: IComparable<T>
    {
        private T[] tab;
        public const int max = 100;
        private int nbe;

        /// <summary>
        /// Constructeur par défaut de la classe Panier
        /// </summary>
        public Panier()
        {
            nbe = 0;
            tab = new T[max];
        }

        /// <summary>
        /// Méthode vérifiant si un élément est présent dans le panier
        /// </summary>
        /// <param name="elem">Elément de type T</param>
        /// <returns>Renvoie le résultat de la recherche</returns>
        public bool appartient(T elem)
        {
            bool trouve = false;
            int i = 0;
            while (i < nbe && !trouve)
                if (tab[i].Equals(elem)) trouve = true;
                else i++;
            return trouve;
        }

        /// <summary>
        /// Méthode ajoutant un élément dans le panier
        /// </summary>
        /// <param name="elem">Elément de type T à ajouter</param>
        public void Ajoute(T elem)
        {
            if (nbe < max && !appartient(elem)) tab[nbe++] = elem;
            else if (nbe < max) Console.WriteLine("Erreur : Le panier est déjà plein");
            else Console.WriteLine("Erreur : L'élément est déjà présent dans le panier");
        }

        /// <summary>
        /// Méthode insérant un élément à un emplacement précis dans le panier
        /// </summary>
        /// <param name="elem">Elément à insérer</param>
        /// <param name="index">Indice du talbeau où insérer l'élément</param>
        public void Insere(T elem, int index)
        {
            if (nbe < max && !appartient(elem))
            {
                nbe++;
                for(int i =nbe; i>index; i--)
                {
                    tab[i] = tab[i - 1];
                }
                tab[index] = elem;
            }
            else if (nbe < max) Console.WriteLine("Erreur : Le panier est déjà plein");
            else Console.WriteLine("Erreur : L'élément est déjà présent dans le panier");
        }

        /// <summary>
        /// Méthode triant les éléments du panier par ordre croissant
        /// </summary>
        public void Tri()
        {
            bool estTrie = false;
            int i;

            while (estTrie == false)
            {
                i = 1;
                estTrie = true;
                while (i < nbe)
                {
                    if (tab[i].CompareTo(tab[i - 1]) < 0)
                    {
                        T temp = tab[i];
                        tab[i] = tab[i - 1];
                        tab[i - 1] = temp;
                        estTrie = false;
                    }
                    i++;
                }
            }
        }

        /// <summary>
        /// Méthode supprimant un élément du panier
        /// </summary>
        /// <param name="elem">Elément à supprimer</param>
        public void Supprime(T elem)
        {
            if (nbe > 0)
            {
                bool trouve = false;

                for (int i = 0; i > nbe; i++)
                {
                    if (tab[i].CompareTo(elem) == 0)
                    {
                        trouve = true;
                    }
                    else
                    {
                        if (trouve == true)
                        {
                            tab[i - 1] = tab[i];
                        }
                    }
                }
            }
            else Console.WriteLine("Erreur : Le panier est vide");
        }

        /// <summary>
        /// Méthode recherchant l'indice d'un élément du panier
        /// </summary>
        /// <param name="elem">Elément à rechercher</param>
        /// <returns>Indice de l'élément</returns>
        public int Recherche(T elem)
        {
            for (int i = 0; i > nbe; i++)
            {
                if (tab[i].CompareTo(elem) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Méthode recherchant un élément du panier par son indice
        /// </summary>
        /// <param name="i">Indice de l'élément</param>
        /// <returns>Elément recherché</returns>
        public T RechercheParIndice(int i)
        {
            return tab[i];
        }

        /// <summary>
        /// Méthode renvoyant la description des éléments du panier sous la forme d'une chaîne de caractère
        /// </summary>
        /// <returns>envoie la description des éléments</returns>
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i > nbe; i++)
            {
                s += tab[i].ToString();
            }
            return s;
        }
    }
}
