using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie1
{
    class Program
    {
        static void Main(string[] args)
        {
            LesMagasins listeMag = new LesMagasins();
            string idMagSel = "";
            Produit prod;

            string id;
            string nom;
            string ville;
            string tel;

            int indice;
            int code;
            Categorie cat;
            string sousCat;

            bool fin = false;

            listeMag.Ajoute(new Magasin());
            listeMag.ListMag.First().RemplirMagasin();
            while(fin == false)
            {
                Console.Clear();
                Console.WriteLine("Magasin sélectionné : " + listeMag.GetMagasin(idMagSel).Nom + "\n");
                Console.WriteLine("Que souhaitez-vous faire ?");

                Console.WriteLine("1 - Gérer les magasins");
                Console.WriteLine("2 - Gérer les produits du magasin sélectionné");
                Console.WriteLine("3 - Faire une recherche");
                Console.WriteLine("0 - Terminer");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Magasin sélectionné : " + listeMag.GetMagasin(idMagSel).Nom + "\n");
                        Console.WriteLine("Que souhaitez-vous faire ?");
                        Console.WriteLine("1 - Créer un nouveau magasin");
                        Console.WriteLine("2 - Supprimer un magasin");
                        Console.WriteLine("3 - Sélectionner un magasin");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Identifiant du magasin ?");
                                id = Console.ReadLine();
                                Console.WriteLine("Nom ?");
                                nom = Console.ReadLine();
                                Console.WriteLine("Ville ?");
                                ville = Console.ReadLine();
                                Console.WriteLine("Tel ?");
                                tel = Console.ReadLine();
                                listeMag.Ajoute(new Magasin(id, nom, ville, tel));
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Identifiant du magasin ?");
                                id = Console.ReadLine();
                                listeMag.Supprime(listeMag.GetMagasin(id));
                                break;
                            case "3":
                                Console.Clear();
                                Console.WriteLine("Identifiant du magasin ?");
                                idMagSel = Console.ReadLine();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Magasin sélectionné : " + listeMag.GetMagasin(idMagSel).Nom + "\n");
                        Console.WriteLine("Que souhaitez-vous faire ?");
                        Console.WriteLine("1 - Ajouter un produit");
                        Console.WriteLine("2 - Ajouter un produit à risque");
                        Console.WriteLine("3 - Supprimer un produit");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Clear();
                                prod = new Produit();
                                prod.Saisie();
                                listeMag.GetMagasin(idMagSel).ListProd.Ajoute(prod);
                                break;
                            case "2":
                                Console.Clear();
                                prod = new ProduitARisque();
                                prod.Saisie();
                                listeMag.GetMagasin(idMagSel).ListProd.Ajoute(prod);
                                break;
                            case "3":
                                Console.Clear();
                                Console.WriteLine("Code du produit ?");
                                code = Int32.Parse(Console.ReadLine());
                                listeMag.GetMagasin(idMagSel).ListProd.Supprime(listeMag.GetMagasin(idMagSel).ListProd.GetProduit(code));
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Magasin sélectionné : " + listeMag.GetMagasin(idMagSel).Nom + "\n");
                        Console.WriteLine("Que souhaitez-vous faire ?");
                        Console.WriteLine("1 - Rechercher un magasin");
                        Console.WriteLine("2 - Rechercher les magasins contenant un certain produit");
                        Console.WriteLine("3 - Récupérer la liste des produits du magasin sélectionné");
                        Console.WriteLine("4 - Récupérer un produit par son code dans le magasin sélectionné");
                        Console.WriteLine("5 - Récupérer un produit par son indice dans le magasin sélectionné");
                        Console.WriteLine("6 - Récupérer la liste des produits d'une catégorie du magasin sélectionné");
                        Console.WriteLine("7 - Récupérer la liste des produits d'une sous-catégorie du magasin sélectionné");
                        Console.WriteLine("8 - Récupérer la liste trié des produits du magasin sélectionné");
                        Console.WriteLine("9 - Récupérer la liste des produits à risque du magasin sélectionné");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Identifiant du magasin ?");
                                id = Console.ReadLine();
                                Console.WriteLine(listeMag.GetMagasin(id).ToString());
                                Console.ReadLine();
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Code du produit ?");
                                code = Int32.Parse(Console.ReadLine());
                                foreach (Magasin m in listeMag.GetMagasinParProduit(code)) Console.WriteLine(m.ToString());
                                Console.ReadLine();
                                break;
                            case "3":
                                Console.Clear();
                                Console.WriteLine(listeMag.GetMagasin(idMagSel).ListProd.ToString());
                                Console.ReadLine();
                                break;
                            case "4":
                                Console.Clear();
                                Console.WriteLine("Code du produit ?");
                                code = Int32.Parse(Console.ReadLine());
                                Console.WriteLine(listeMag.GetMagasin(idMagSel).ListProd.GetProduit(code).ToString());
                                Console.ReadLine();
                                break;
                            case "5":
                                Console.Clear();
                                Console.WriteLine("Indice du produit ?");
                                indice = Int32.Parse(Console.ReadLine());
                                Console.WriteLine(listeMag.GetMagasin(idMagSel).ListProd.GetProduitIndice(indice).ToString());
                                Console.ReadLine();
                                break;
                            case "6":
                                Console.Clear();
                                Console.WriteLine("Code du produit ?");
                                cat = (Categorie)Enum.Parse(typeof(Categorie), Console.ReadLine(), false);
                                foreach (Produit p in listeMag.GetMagasin(idMagSel).ListProd.GetProdCategorie(cat)) Console.WriteLine(p.ToString());
                                Console.ReadLine();
                                break;
                            case "7":
                                Console.Clear();
                                Console.WriteLine("Code du produit ?");
                                sousCat = Console.ReadLine();
                                foreach (Produit p in listeMag.GetMagasin(idMagSel).ListProd.GetProduitSousCat(sousCat)) Console.WriteLine(p.ToString());
                                Console.ReadLine();
                                break;
                            case "8":
                                Console.Clear();
                                foreach (Produit p in listeMag.GetMagasin(idMagSel).ListProd.TriProd()) Console.WriteLine(p.ToString());
                                Console.ReadLine();
                                break;
                            case "9":
                                Console.Clear();
                                foreach (Produit p in listeMag.GetMagasin(idMagSel).ListProd.ListePAR()) Console.WriteLine(p.ToString());
                                Console.ReadLine();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "0":
                        fin = true;
                        break;
                    default:
                        break;
                }
            }            
        }
    }
}
