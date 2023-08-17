using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Panier<Produit> panierProduit = new Panier<Produit>();
            Panier<Livre> panierLivre = new Panier<Livre>();
            
            string typeCourant = "produit";

            bool fin = false;

            while (fin == false)
            {
                Console.Clear();
                Console.WriteLine("Ce panier contient des " + typeCourant + "s\n");
                Console.WriteLine("Que souhaitez-vous faire ?");
                Console.WriteLine("1 - Changer de panier");
                Console.WriteLine("2 - Ajouter un " + typeCourant + " au panier");
                Console.WriteLine("3 - Insérer un " + typeCourant + " au panier");
                Console.WriteLine("4 - Trier les " + typeCourant + "s du panier");
                Console.WriteLine("5 - Supprimer un " + typeCourant + " du panier");
                Console.WriteLine("6 - Rechercher l'indice d'un " + typeCourant);
                Console.WriteLine("7 - Rechercher le " + typeCourant + " à l'indice choisie");
                Console.WriteLine("0 - Terminer");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Que souhaitez-vous faire ?");
                        Console.WriteLine("1 - Choisir le panier de produits");
                        Console.WriteLine("2 - Choisir le panier de livres");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                typeCourant = "produit";
                                break;
                            case "2":
                                typeCourant = "livre";
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        if (typeCourant == "produit")
                        {
                            Produit p = new Produit();
                            p.Saisie();
                            panierProduit.Ajoute(p);
                        }
                        else 
                        {
                            Livre l = new Livre();
                            l.Saisie();
                            panierLivre.Ajoute(l);
                        }
                        break;
                    case "3":
                        Console.Clear();
                        if (typeCourant == "produit")
                        {
                            Produit p = new Produit();
                            p.Saisie();
                            Console.WriteLine("Indice du produit ?");
                            panierProduit.Insere(p, Int32.Parse(Console.ReadLine()));
                        }
                        else
                        {
                            Livre l = new Livre();
                            l.Saisie();
                            Console.WriteLine("Indice du livre ?");
                            panierLivre.Insere(l, Int32.Parse(Console.ReadLine()));
                        }
                        break;
                    case "4":
                        if (typeCourant == "produit")
                        {
                            panierProduit.Tri();
                        }
                        else
                        {
                            panierLivre.Tri();
                        }
                        break;
                    case "5":
                        Console.Clear();
                        if (typeCourant == "produit")
                        {
                            Console.WriteLine("Indice du produit ?");
                            panierProduit.Supprime(panierProduit.RechercheParIndice(Int32.Parse(Console.ReadLine())));
                        }
                        else
                        {
                            Console.WriteLine("Indice du livre ?");
                            panierLivre.Supprime(panierLivre.RechercheParIndice(Int32.Parse(Console.ReadLine())));
                        }
                        break;
                    case "6":
                        Console.Clear();
                        if (typeCourant == "produit")
                        {
                            Produit p = new Produit();
                            p.Saisie();
                            Console.WriteLine(panierProduit.Recherche(p));
                            Console.ReadLine();
                        }
                        else
                        {
                            Livre l = new Livre();
                            l.Saisie();
                            Console.WriteLine(panierLivre.Recherche(l));
                            Console.ReadLine();
                        }
                        break;
                    case "7":
                        Console.Clear();
                        if (typeCourant == "produit")
                        {
                            Console.WriteLine("Indice du produit ?");
                            Console.WriteLine(panierProduit.RechercheParIndice(Int32.Parse(Console.ReadLine())).ToString());
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Indice du livre ?");
                            Console.WriteLine(panierLivre.RechercheParIndice(Int32.Parse(Console.ReadLine())).ToString());
                            Console.ReadLine();
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
