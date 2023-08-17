using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie3
{
    class Aliment
    {
        private int numero;
        private string nom;
        private string origine;
        private double prix;

        /// <summary>
        /// Constructeur par défaut de la classe Aliment
        /// </summary>
        public Aliment()
        {
            this.numero = -1;
            this.nom = "Inconnu";
            this.origine = "Inconnu";
            this.prix = 0;
        }

        /// <summary>
        /// Constructeur avec paramètres de la classe Aliment
        /// </summary>
        /// <param name="numero">Numero de l'aliment</param>
        /// <param name="nom">Nom de l'aliment</param>
        /// <param name="origine">Origine de l'aliment</param>
        /// <param name="prix">Prix de l'aliment</param>
        public Aliment(int numero, string nom, string origine, double prix)
        {
            this.numero = numero;
            this.nom = nom;
            this.origine = origine;
            this.prix = prix;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }


        public string Origine
        {
            get { return origine; }
            set { origine = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        /// <summary>
        /// Méthode renvoyant la description de l'aliment sous la forme d'une chaîne de caractère
        /// </summary>
        /// <returns>Renvoie la description de l'aliment</returns>
        public override string ToString()
        {
            string s = "";
            s += "Numero : " + numero + "\n";
            s += "Nom : " + nom + "\n";
            s += "Origine : " + origine + "\n";
            s += "Prix : " + prix + "\n";
            return s;
        }

        /// <summary>
        /// Méthode permettant la saisie dans la console des valeurs des attributs de l'aliment
        /// </summary>
        public virtual void Saisie()
        {
            String s;
            Console.WriteLine("Numero ?");
            s = Console.ReadLine();
            numero = Int32.Parse(s);
            Console.WriteLine("Nom ?");
            s = Console.ReadLine();
            nom = s;
            Console.WriteLine("Origine ?");
            s = Console.ReadLine();
            origine = s;
            Console.WriteLine("Prix ?");
            s = Console.ReadLine();
            prix = Double.Parse(s, System.Globalization.NumberStyles.Float);
        }
    }
}
