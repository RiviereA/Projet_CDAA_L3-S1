using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie2
{
    class Livre:IComparable<Livre>
    {
        private int id;
        private string titre;
        private string auteur;
        private double prix;

        /// <summary>
        /// Constructeur par défaut de la classe Livre
        /// </summary>
        public Livre()
        {
            this.id = -1;
            this.titre = "Inconnu";
            this.auteur = "Inconnu";
            this.prix = 0;
        }

        /// <summary>
        /// Constructeur avec paramètres de la classe Livre
        /// </summary>
        /// <param name="id">Identifiant du livre</param>
        /// <param name="titre">Titre du livre</param>
        /// <param name="auteur">Auteur du livre</param>
        /// <param name="prix">Prix du livre</param>
        public Livre(int id, string titre, string auteur, double prix)
        {
            this.id = id;
            this.titre = titre;
            this.auteur = auteur;
            this.prix = prix;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }


        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        /// <summary>
        /// Méthode renvoyant la description du livre sous la forme d'une chaîne de caractère
        /// </summary>
        /// <returns>Renvoie la description du livre</returns>
        public override string ToString()
        {
            string s = "";
            s += "Identifiant : " + id + "\n";
            s += "Titre : " + titre + "\n";
            s += "Auteur : " + auteur + "\n";
            s += "Prix : " + prix + "\n";
            return s;
        }

        /// <summary>
        /// Méthode permettant la saisie dans la console des valeurs des attributs du livre
        /// </summary>
        public virtual void Saisie()
        {
            String s;
            Console.WriteLine("Identifiant ?");
            s = Console.ReadLine();
            id = Int32.Parse(s);
            Console.WriteLine("Titre ?");
            s = Console.ReadLine();
            titre = s;
            Console.WriteLine("Auteur ?");
            s = Console.ReadLine();
            auteur = s;
            Console.WriteLine("Prix ?");
            s = Console.ReadLine();
            prix = Double.Parse(s, System.Globalization.NumberStyles.Float);
            
        }

        public int CompareTo(Livre other)
        {
            return (this.id.CompareTo(other.id));
        }

        public int CompareTo(object obj)
        {
            Livre objAsLivre = obj as Livre;
            return CompareTo(objAsLivre);
        }

        public static bool operator <(Livre p1, Livre p2)
        {
            return p1.CompareTo(p2) < 0;
        }

        public static bool operator >(Livre p1, Livre p2)
        {
            return p1.CompareTo(p2) > 0;
        }

        public static bool operator <=(Livre p1, Livre p2)
        {
            return p1.CompareTo(p2) <= 0;
        }

        public static bool operator >=(Livre p1, Livre p2)
        {
            return p1.CompareTo(p2) >= 0;
        }
    }
}
