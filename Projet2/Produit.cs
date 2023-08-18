using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Projet2CDAA
{
    public enum Categorie { Consommable, NonConsommable }

    public class Produit:IEquatable<Produit>,IComparable<Produit>
    {

        private int code;
        private string nom;
        private double prix;
        private Categorie cat;
        private string sousCat;

        private Image img; 

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
            this.img = Image.FromFile(Path.GetFullPath(Application.StartupPath + "\\..\\..\\point_interrogation.jpg"));
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
            this.img = Image.FromFile(Path.GetFullPath(Application.StartupPath + "\\..\\..\\point_interrogation.jpg"));
        }

        /// <summary>
        /// Constructeur avec paramètres, image inclus, de la classe Produit
        /// </summary>
        /// <param name="code">Code du produit</param>
        /// <param name="nom">Nom du produit</param>
        /// <param name="prix">Prix du produit</param>
        /// <param name="cat">Catégorie du produit</param>
        /// <param name="sousCat">Sous-catégorie du produit</param>
        /// <param name="img">Image du produit</param>
        public Produit(int code, string nom, double prix, Categorie cat, string sousCat, Image img)
        {
            this.code = code;
            this.nom = nom;
            this.prix = prix;
            this.cat = cat;
            this.sousCat = sousCat;
            this.img = img;
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

        public Image Img
        {
            get { return img; }
            set { img = value; }
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
