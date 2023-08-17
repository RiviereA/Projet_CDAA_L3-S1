using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie1
{
    class Magasin:IEquatable<Magasin>
    {
        private string idMag;
        private string nom;
        private string tel;
        private string ville;
        private LesProduits listProd;

        /// <summary>
        /// Constructeur par défaut de la classe Magasin
        /// </summary>
        public Magasin()
        {
            this.idMag = "";
            this.nom = "Inconnu";
            this.tel = "";
            this.ville = "";
            this.listProd = new LesProduits();
        }

        /// <summary>
        /// Constructeur avec paramètres de la classe Magasin
        /// </summary>
        /// <param name="idMag">Identifiant du magasin</param>
        /// <param name="nom">Nom du magasin</param>
        /// <param name="ville">Ville où est situé le magasin</param>
        /// <param name="tel">Numéro de téléphone du magasin</param>
        public Magasin(string idMag, string nom, string ville, string tel)
        {
            this.idMag = idMag;
            this.nom = nom;
            this.tel = tel;
            this.ville = ville;
            this.listProd = new LesProduits();
        }

        public string IdMag
        { get { return idMag; }
        set { this.idMag = value; } }

        public string Nom
        {
            get { return nom; }
            set { this.nom = value; }
        }

        public string Ville
        {
            get { return ville; }
            set { this.ville = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { this.tel = value; }
        }
        
        public LesProduits ListProd { get { return listProd; } }

        /// <summary>
        /// Méthode renvoyant la description du magasin sous la forme d'une chaîne de caractère
        /// </summary>
        /// <returns>Renvoie la description du magasin</returns>
        public override string ToString()
        {
            string s = "\nMagasin : \n";
            s += "Id : " + this.idMag + "\n";
            s += "Nom : " + this.nom + "\n";
            s += "Ville : " + this.ville + "\n";
            s += "Tel : " + this.tel + "\n";
            s += listProd.ToString();
            return s;
        }

        /// <summary>
        /// Méthode ajoutant plusieurs produit à la liste des produits du magasin
        /// </summary>
        public void RemplirMagasin()
        {
            this.listProd.Ajoute(new Produit(1,"Produit n°1",3.00,Categorie.Consommable,"Alimentaire"));
            this.listProd.Ajoute(new Produit(2, "Produit n°2", 5.00, Categorie.Consommable, "Outils"));
            this.listProd.Ajoute(new Produit(3, "Produit n°3", 7.00, Categorie.NonConsommable, "Mobilier"));
        }

        public bool Equals(Magasin other)
        {
            if (other == null) return false;
            return (this.idMag.Equals(other.idMag));
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Magasin objAsMagasin = obj as Magasin;
            if (objAsMagasin == null) return false;
            else return Equals(objAsMagasin);
        }

        public static bool operator ==(Magasin p1, Magasin p2)
        {
            if ((Object)p1 == null) return ((Object)p2 == null);
            return p1.Equals(p2);
        }

        public static bool operator !=(Magasin p1, Magasin p2)
        {
            if ((Object)p1 == null) return ((Object)p2 == null);
            return !p1.Equals(p2);
        }

        public int CompareTo(Magasin other)
        {
            return (this.idMag.CompareTo(other.idMag));
        }

        public int CompareTo(object obj)
        {
            Magasin objAsProduit = obj as Magasin;
            return CompareTo(objAsProduit);
        }

        public static bool operator <(Magasin p1, Magasin p2)
        {
            return p1.CompareTo(p2) < 0;
        }

        public static bool operator >(Magasin p1, Magasin p2)
        {
            return p1.CompareTo(p2) > 0;
        }

        public static bool operator <=(Magasin p1, Magasin p2)
        {
            return p1.CompareTo(p2) <= 0;
        }

        public static bool operator >=(Magasin p1, Magasin p2)
        {
            return p1.CompareTo(p2) >= 0;
        }
    }
}
