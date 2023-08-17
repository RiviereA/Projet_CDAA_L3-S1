using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Magasin magasin = new Magasin();
            Librairie librairie = new Librairie();
            Grenier grenier = new Grenier();

            magasin.RemplirMagasin();
            librairie.RemplirLibrairie();
            grenier.RemplirGrenier();

            Produit p;
            Livre l;
            Aliment a;

            bool fin = false;

            while (fin == false)
            {
                Console.Clear();
                
                Console.WriteLine("Que souhaitez-vous faire ?");
                Console.WriteLine("1 - Gérer le magasin");
                Console.WriteLine("2 - Gérer la librairie");
                Console.WriteLine("3 - Gérer le grenier");
                Console.WriteLine("0 - Terminer");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Que souhaitez-vous faire ?");
                        Console.WriteLine("1 - Ajouter un produit");
                        Console.WriteLine("2 - Modifier un produit");
                        Console.WriteLine("3 - Supprimer un produit");
                        Console.WriteLine("4 - Rechercher un produit");
                        Console.WriteLine("5 - Afficher la liste trié des produits");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                p = new Produit();
                                p.Saisie();
                                magasin.Ajoute(p);
                                break;
                            case "2":
                                p = new Produit();
                                p.Saisie();
                                magasin.Modifie(p);
                                break;
                            case "3":
                                Console.WriteLine("Saisissez le code du produit");
                                magasin.Supprime(Int32.Parse(Console.ReadLine()));
                                break;
                            case "4":
                                Console.WriteLine("Saisissez le code du produit");
                                Console.WriteLine(magasin.Recherche(Int32.Parse(Console.ReadLine())).ToString());
                                Console.ReadLine();
                                break;
                            case "5":
                                Console.WriteLine(magasin.ToString());
                                Console.ReadLine();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Que souhaitez-vous faire ?");
                        Console.WriteLine("1 - Ajouter un livre");
                        Console.WriteLine("2 - Modifier un livre");
                        Console.WriteLine("3 - Trier les livres");
                        Console.WriteLine("4 - Supprimer un livre");
                        Console.WriteLine("5 - Rechercher un livre");
                        Console.WriteLine("6 - Afficher la liste des livres");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                l = new Livre();
                                l.Saisie();
                                librairie.Ajoute(l);
                                break;
                            case "2":
                                l = new Livre();
                                l.Saisie();
                                librairie.Modifie(l);
                                break;
                            case "3":
                                librairie.Tri();
                                break;
                            case "4":
                                Console.WriteLine("Saisissez l'identifiant du livre");
                                librairie.Supprime(Console.ReadLine());
                                break;
                            case "5":
                                Console.WriteLine("Saisissez l'identifiant du livre");
                                Console.WriteLine(librairie.Recherche(Console.ReadLine()).ToString());
                                Console.ReadLine();
                                break;
                            case "6":
                                Console.WriteLine(librairie.ToString());
                                Console.ReadLine();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Que souhaitez-vous faire ?");
                        Console.WriteLine("1 - Ajouter un aliment");
                        Console.WriteLine("2 - Modifier un aliment");
                        Console.WriteLine("3 - Supprimer un aliment");
                        Console.WriteLine("4 - Rechercher un aliment");
                        Console.WriteLine("5 - Afficher la liste des aliments");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                a = new Aliment();
                                a.Saisie();
                                grenier.Ajoute(a);
                                break;
                            case "2":
                                a = new Aliment();
                                a.Saisie();
                                grenier.Modifie(a);
                                break;
                            case "3":
                                Console.WriteLine("Saisissez le numéro du produit alimentaire");
                                grenier.Supprime(Int32.Parse(Console.ReadLine()));
                                break;
                            case "4":
                                Console.WriteLine("Saisissez le numéro du produit alimentaire");
                                Console.WriteLine(grenier.Recherche(Int32.Parse(Console.ReadLine())).ToString());
                                Console.ReadLine();
                                break;
                            case "5":
                                Console.WriteLine(grenier.ToString());
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
