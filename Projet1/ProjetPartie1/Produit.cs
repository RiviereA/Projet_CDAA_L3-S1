using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie1
{
    public enum Categorie { Consommable, NonConsommable }

    class Produit:IEquatable<Produit>,IComparable<Produit>
    {

        private int code;
        private string nom;
        private double prix;
        private Categorie cat;
        private string sousCat;

        /// <summary>
        /// Constructeur par défaut de la classe Produit
        /// </summary>
        public Produit()
        {
            this.code = -1;
            this.nom = "Inconnu";
            this.prix = 0;
            this.cat = Categorie.NonConsommable;
            this.sousCat = "";
        }

        /// <summary>
        /// Constructeur avec paramètres de la classe Produit
        /// </summary>
        /// <param name="code">Code du produit</param>
        /// <param name="nom">Nom du produit</param>
        /// <param name="prix">Prix du produit</param>
        /// <param name="cat">Catégorie du produit</param>
        /// <param name="sousCat">Sous-catégorie du produit</param>
        public Produit(int code, string nom, double prix, Categorie cat, string sousCat)
        {
            this.code = code;
            this.nom = nom;
            this.prix = prix;
            this.cat = cat;
            this.sousCat = sousCat;
        }
        
        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public Categorie Cat
        {
            get { return cat; }
            set { cat = value; }
        }

        /// <summary>
        /// Accesseur permettant la récupération et la saisie de la catégorie d'un produit sous forme de chaîne de caractère
        /// </summary>
        public string CatS
        {
            get { return Enum.Format(typeof(Categorie), cat, "g"); }
            set { cat = (Categorie)Enum.Parse(typeof(Categorie), value, false); }
        }

        public string SousCat
        {
            get { return sousCat; }
            set { sousCat = value; }
        }
        
        /// <summary>
        /// Méthode renvoyant la description du produit sous la forme d'une chaîne de caractère
        /// </summary>
        /// <returns>Renvoie la description du produit</returns>
        public override string ToString()
        {
            string s = "";
            s += "Code : " + code + "\n";
            s += "Nom : " + nom + "\n";
            s += "Prix : " + prix + "\n";
            s += "Categorie : " + CatS + "\n";
            s += "Sous catégorie : " + sousCat + "\n";
            return s;
        }

        /// <summary>
        /// Méthode affichant dans la console la valeur des attributs du produit
        /// </summary>
        public virtual void affiche()
        {
            Console.WriteLine(this.ToString());
        }

        /// <summary>
        /// Méthode permettant la saisie dans la console des valeurs des attributs du produit
        /// </summary>
        public virtual void Saisie()
        {
            String s;
            Console.WriteLine("Code ?");
            s = Console.ReadLine();
            code = Int32.Parse(s);
            Console.WriteLine("Nom ?");
            s = Console.ReadLine();
            nom = s;
            Console.WriteLine("Prix ?");
            s = Console.ReadLine();
            prix = Double.Parse(s,System.Globalization.NumberStyles.Float);
            Console.WriteLine("Catégorie ?");
            s = Console.ReadLine();
            CatS = s;
            Console.WriteLine("Sous catégorie ?");
            s = Console.ReadLine();
            sousCat = s;
        }

        public bool Equals(Produit other)
        {
            if (other == null) return false;
            return (this.code.Equals(other.code));
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Produit objAsProduit = obj as Produit;
            if (objAsProduit == null) return false;
            else return Equals(objAsProduit);
        }

        public static bool operator ==(Produit p1, Produit p2)
        {
            if ((Object)p1 == null) return ((Object)p2 == null);
            return p1.Equals(p2);
        }

        public static bool operator !=(Produit p1, Produit p2)
        {
            if ((Object)p1 == null) return ((Object)p2 == null);
            return !p1.Equals(p2);
        }

        public int CompareTo(Produit other)
        {
            return (this.code.CompareTo(other.code));
        }

        public int CompareTo(object obj)
        {
            Produit objAsProduit = obj as Produit;
            return CompareTo(objAsProduit);
        }

        public static bool operator <(Produit p1, Produit p2)
        {
            return p1.CompareTo(p2) < 0;
        }

        public static bool operator >(Produit p1, Produit p2)
        {
            return p1.CompareTo(p2) > 0;
        }

        public static bool operator <=(Produit p1, Produit p2)
        {
            return p1.CompareTo(p2) <= 0;
        }

        public static bool operator >=(Produit p1, Produit p2)
        {
            return p1.CompareTo(p2) >= 0;
        }
    }
}
