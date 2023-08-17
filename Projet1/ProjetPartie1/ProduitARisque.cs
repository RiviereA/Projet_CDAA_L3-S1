using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie1
{
    class ProduitARisque:Produit
    {
        private string typeR;
        private string regles;

        /// <summary>
        /// Constructeur par défaut de la classe ProduitARisque
        /// </summary>
        public ProduitARisque():base()
        {
            this.typeR = "Inconnu";
            this.regles = "";
        }

        /// <summary>
        /// Constructeur avec paramètres de la classe ProduitARisque
        /// </summary>
        /// <param name="code">Code du produit</param>
        /// <param name="nom">Nom du produit</param>
        /// <param name="prix">Prix du produit</param>
        /// <param name="cat">Catégorie du produit</param>
        /// <param name="sousCat">Sous-catégorie du produit</param>
        /// <param name="tr">Types de risques lié à ce produit</param>
        /// <param name="r">Règles lié à ce produit</param>
        public ProduitARisque(int code, string nom, double prix, Categorie cat, string sousCat, string tr, string r):base(code,nom,prix,cat,sousCat)
        {
            this.typeR = tr;
            this.regles = r;
        }

        public string TypeR
        {
            get { return typeR; }
            set { typeR = value; }
        }

        public string Regles
        {
            get { return regles; }
            set { regles = value; }
        }

        /// <summary>
        /// Méthode renvoyant la description du produit sous la forme d'une chaîne de caractère
        /// </summary>
        /// <returns>Renvoie la description du produit</returns>
        public override string ToString()
        {
            string s = "";
            s += base.ToString();
            s += "Type de risque : " + typeR + "\n";
            s += "Regles : " + regles + "\n";
            return s;
        }

        /// <summary>
        /// Méthode affichant dans la console la valeur des attributs du produit
        /// </summary>
        public override void affiche()
        {
            Console.WriteLine(this.ToString());
        }

        /// <summary>
        /// Méthode permettant la saisie dans la console des valeurs des attributs du produit
        /// </summary>
        public override void Saisie()
        {
            base.Saisie();
            String s;
            Console.WriteLine("Type ?");
            s = Console.ReadLine();
            typeR = s;
            Console.WriteLine("Regles ?");
            s = Console.ReadLine();
            regles = s;
        }
    }
}
