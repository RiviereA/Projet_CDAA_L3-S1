using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2CDAA
{
    public partial class Recherche : Form
    {
        private LesMagasins listMag;

        /// <summary>
        /// Constructeur par défaut de la fenêtre Recherche
        /// </summary>
        public Recherche()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur avec paramètres de la fenêtre Recherche
        /// </summary>
        /// <param name="lst">Liste des magasins transmise par la fenêtre principale</param>
        public Recherche(ref LesMagasins lst)
        {
            InitializeComponent();
            listMag = lst;
            comboRech.Items.Add("Rechercher un magasin");
            comboRech.Items.Add("Rechercher les magasins contenant un certain produit");
            comboRech.Items.Add("Récupérer la liste des produits d'un magasin");
            comboRech.Items.Add("Récupérer un produit par son code");
            comboRech.Items.Add("Récupérer la liste des produits d'une catégorie");
            comboRech.Items.Add("Récupérer la liste des produits d'une sous-catégorie");
            comboRech.Items.Add("Récupérer la liste trié des produits");
            comboRech.Items.Add("Récupérer la liste des produits à risque");
            comboRech.SelectedIndex = 0;
            comboMag.Items.Add("Tous");
            foreach (Magasin m in listMag.ListMag) comboMag.Items.Add(m.Nom);
            comboMag.SelectedIndex = 0;
        }
        
        private void buttonRech_Click(object sender, EventArgs e)
        {
            dataGridRes.Columns.Clear();
            switch (comboRech.SelectedIndex)
            {
                case 0:
                    dataGridRes.Columns.Add("colId", "Identifiant");
                    dataGridRes.Columns.Add("colNom", "Nom");
                    dataGridRes.Columns.Add("colVille", "Ville");
                    dataGridRes.Columns.Add("colTel", "Tel");
                    Magasin m = listMag.GetMagasin(textVal.Text);
                    dataGridRes.Rows.Add(new Object[] { m.IdMag, m.Nom, m.Ville, m.Tel });
                    break;
                case 1:
                    dataGridRes.Columns.Add("colId", "Identifiant");
                    dataGridRes.Columns.Add("colNom", "Nom");
                    dataGridRes.Columns.Add("colVille", "Ville");
                    dataGridRes.Columns.Add("colTel", "Tel");
                    List <Magasin> listM = listMag.GetMagasinParProduit(Int32.Parse(textVal.Text));
                    foreach (Magasin m1 in listM) dataGridRes.Rows.Add(new Object[] { m1.IdMag, m1.Nom, m1.Ville, m1.Tel });
                    break;
                case 2:
                    dataGridRes.Columns.Add("colCode", "Code");
                    dataGridRes.Columns.Add("colNom", "Nom");
                    dataGridRes.Columns.Add("colPrix", "Prix");
                    dataGridRes.Columns.Add("colCat", "Catégorie");
                    dataGridRes.Columns.Add("colSousCat", "Sous Catégorie");
                    dataGridRes.Columns.Add("colTypeR", "Types de risques");
                    dataGridRes.Columns.Add("colRegles", "Règles");

                    if (comboMag.SelectedItem.ToString() == "Tous")
                    {
                        foreach (Magasin m2 in listMag.ListMag)
                        {
                            foreach (Produit p in m2.ListProd.ListProd)
                            {
                                if (p.ToString().Contains("Type de risque : ") && p.ToString().Contains("Regles : "))
                                {
                                    ProduitARisque par = (ProduitARisque)p;
                                    dataGridRes.Rows.Add(new Object[] { par.Code, par.Nom, par.Prix, par.CatS, par.SousCat, par.TypeR, par.Regles });
                                }
                                else
                                {
                                    dataGridRes.Rows.Add(new Object[] { p.Code, p.Nom, p.Prix, p.CatS, p.SousCat });
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (Produit p in listMag.GetMagasin(comboMag.SelectedItem.ToString()).ListProd.ListProd)
                        {
                            if (p.ToString().Contains("Type de risque : ") && p.ToString().Contains("Regles : "))
                            {
                                ProduitARisque par = (ProduitARisque)p;
                                dataGridRes.Rows.Add(new Object[] { par.Code, par.Nom, par.Prix, par.CatS, par.SousCat, par.TypeR, par.Regles });
                            }
                            else
                            {
                                dataGridRes.Rows.Add(new Object[] { p.Code, p.Nom, p.Prix, p.CatS, p.SousCat });
                            }
                        }
                    }
                    break;
                case 3:
                    dataGridRes.Columns.Add("colCode", "Code");
                    dataGridRes.Columns.Add("colNom", "Nom");
                    dataGridRes.Columns.Add("colPrix", "Prix");
                    dataGridRes.Columns.Add("colCat", "Catégorie");
                    dataGridRes.Columns.Add("colSousCat", "Sous Catégorie");
                    dataGridRes.Columns.Add("colTypeR", "Types de risques");
                    dataGridRes.Columns.Add("colRegles", "Règles");
                    if (comboMag.SelectedItem.ToString() == "Tous")
                    {
                        foreach (Magasin m3 in listMag.ListMag)
                        {
                            Produit p = m3.ListProd.GetProduit(Int32.Parse(textVal.Text));
                            if (p.ToString().Contains("Type de risque : ") && p.ToString().Contains("Regles : "))
                            {
                                ProduitARisque par = (ProduitARisque)p;
                                dataGridRes.Rows.Add(new Object[] { par.Code, par.Nom, par.Prix, par.CatS, par.SousCat, par.TypeR, par.Regles });
                            }
                            else
                            {
                                dataGridRes.Rows.Add(new Object[] { p.Code, p.Nom, p.Prix, p.CatS, p.SousCat });
                            }
                        }
                    }
                    else
                    {
                        Produit p = listMag.GetMagasinNom(comboMag.SelectedItem.ToString()).ListProd.GetProduit(Int32.Parse(textVal.Text));
                        if (p.ToString().Contains("Type de risque : ") && p.ToString().Contains("Regles : "))
                        {
                            ProduitARisque par = (ProduitARisque)p;
                            dataGridRes.Rows.Add(new Object[] { par.Code, par.Nom, par.Prix, par.CatS, par.SousCat, par.TypeR, par.Regles });
                        }
                        else
                        {
                            dataGridRes.Rows.Add(new Object[] { p.Code, p.Nom, p.Prix, p.CatS, p.SousCat });
                        }
                    }
                    break;
                case 4:
                    dataGridRes.Columns.Add("colCode", "Code");
                    dataGridRes.Columns.Add("colNom", "Nom");
                    dataGridRes.Columns.Add("colPrix", "Prix");
                    dataGridRes.Columns.Add("colCat", "Catégorie");
                    dataGridRes.Columns.Add("colSousCat", "Sous Catégorie");
                    dataGridRes.Columns.Add("colTypeR", "Types de risques");
                    dataGridRes.Columns.Add("colRegles", "Règles");
                    if (comboMag.SelectedItem.ToString() == "Tous")
                    {
                        foreach (Magasin m4 in listMag.ListMag)
                        {
                            foreach (Produit p in m4.ListProd.GetProdCategorie((Categorie)Enum.Parse(typeof(Categorie), textVal.Text, false)))
                            {
                                if (p.ToString().Contains("Type de risque : ") && p.ToString().Contains("Regles : "))
                                {
                                    ProduitARisque par = (ProduitARisque)p;
                                    dataGridRes.Rows.Add(new Object[] { par.Code, par.Nom, par.Prix, par.CatS, par.SousCat, par.TypeR, par.Regles });
                                }
                                else
                                {
                                    dataGridRes.Rows.Add(new Object[] { p.Code, p.Nom, p.Prix, p.CatS, p.SousCat });
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (Produit p in listMag.GetMagasinNom(comboMag.SelectedItem.ToString()).ListProd.GetProdCategorie((Categorie)Enum.Parse(typeof(Categorie), textVal.Text, false)))
                        {
                            if (p.ToString().Contains("Type de risque : ") && p.ToString().Contains("Regles : "))
                            {
                                ProduitARisque par = (ProduitARisque)p;
                                dataGridRes.Rows.Add(new Object[] { par.Code, par.Nom, par.Prix, par.CatS, par.SousCat, par.TypeR, par.Regles });
                            }
                            else
                            {
                                dataGridRes.Rows.Add(new Object[] { p.Code, p.Nom, p.Prix, p.CatS, p.SousCat });
                            }
                        }
                    }
                    break;
                case 5:
                    dataGridRes.Columns.Add("colCode", "Code");
                    dataGridRes.Columns.Add("colNom", "Nom");
                    dataGridRes.Columns.Add("colPrix", "Prix");
                    dataGridRes.Columns.Add("colCat", "Catégorie");
                    dataGridRes.Columns.Add("colSousCat", "Sous Catégorie");
                    dataGridRes.Columns.Add("colTypeR", "Types de risques");
                    dataGridRes.Columns.Add("colRegles", "Règles");
                    if (comboMag.SelectedItem.ToString() == "Tous")
                    {
                        foreach (Magasin m5 in listMag.ListMag)
                        {
                            foreach (Produit p in m5.ListProd.GetProduitSousCat(textVal.Text))
                            {
                                if (p.ToString().Contains("Type de risque : ") && p.ToString().Contains("Regles : "))
                                {
                                    ProduitARisque par = (ProduitARisque)p;
                                    dataGridRes.Rows.Add(new Object[] { par.Code, par.Nom, par.Prix, par.CatS, par.SousCat, par.TypeR, par.Regles });
                                }
                                else
                                {
                                    dataGridRes.Rows.Add(new Object[] { p.Code, p.Nom, p.Prix, p.CatS, p.SousCat });
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (Produit p in listMag.GetMagasinNom(comboMag.SelectedItem.ToString()).ListProd.GetProduitSousCat(textVal.Text))
                        {
                            if (p.ToString().Contains("Type de risque : ") && p.ToString().Contains("Regles : "))
                            {
                                ProduitARisque par = (ProduitARisque)p;
                                dataGridRes.Rows.Add(new Object[] { par.Code, par.Nom, par.Prix, par.CatS, par.SousCat, par.TypeR, par.Regles });
                            }
                            else
                            {
                                dataGridRes.Rows.Add(new Object[] { p.Code, p.Nom, p.Prix, p.CatS, p.SousCat });
                            }
                        }
                    }
                    break;
                case 6:
                    dataGridRes.Columns.Add("colCode", "Code");
                    dataGridRes.Columns.Add("colNom", "Nom");
                    dataGridRes.Columns.Add("colPrix", "Prix");
                    dataGridRes.Columns.Add("colCat", "Catégorie");
                    dataGridRes.Columns.Add("colSousCat", "Sous Catégorie");
                    dataGridRes.Columns.Add("colTypeR", "Types de risques");
                    dataGridRes.Columns.Add("colRegles", "Règles");
                    if (comboMag.SelectedItem.ToString() == "Tous")
                    {
                        foreach (Magasin m6 in listMag.ListMag)
                        {
                            foreach (Produit p in m6.ListProd.TriProd())
                            {
                                if (p.ToString().Contains("Type de risque : ") && p.ToString().Contains("Regles : "))
                                {
                                    ProduitARisque par = (ProduitARisque)p;
                                    dataGridRes.Rows.Add(new Object[] { par.Code, par.Nom, par.Prix, par.CatS, par.SousCat, par.TypeR, par.Regles });
                                }
                                else
                                {
                                    dataGridRes.Rows.Add(new Object[] { p.Code, p.Nom, p.Prix, p.CatS, p.SousCat });
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (Produit p in listMag.GetMagasinNom(comboMag.SelectedItem.ToString()).ListProd.TriProd())
                        {
                            if (p.ToString().Contains("Type de risque : ") && p.ToString().Contains("Regles : "))
                            {
                                ProduitARisque par = (ProduitARisque)p;
                                dataGridRes.Rows.Add(new Object[] { par.Code, par.Nom, par.Prix, par.CatS, par.SousCat, par.TypeR, par.Regles });
                            }
                            else
                            {
                                dataGridRes.Rows.Add(new Object[] { p.Code, p.Nom, p.Prix, p.CatS, p.SousCat });
                            }
                        }
                    }
                    break;
                case 7:
                    dataGridRes.Columns.Add("colCode", "Code");
                    dataGridRes.Columns.Add("colNom", "Nom");
                    dataGridRes.Columns.Add("colPrix", "Prix");
                    dataGridRes.Columns.Add("colCat", "Catégorie");
                    dataGridRes.Columns.Add("colSousCat", "Sous Catégorie");
                    dataGridRes.Columns.Add("colTypeR", "Types de risques");
                    dataGridRes.Columns.Add("colRegles", "Règles");
                    if (comboMag.SelectedItem.ToString() == "Tous")
                    {
                        foreach (Magasin m7 in listMag.ListMag)
                        {
                            foreach (Produit p in m7.ListProd.ListePAR())
                            {
                                ProduitARisque par = (ProduitARisque)p;
                                dataGridRes.Rows.Add(new Object[] { par.Code, par.Nom, par.Prix, par.CatS, par.SousCat, par.TypeR, par.Regles });
                            }
                        }
                    }
                    else
                    {
                        foreach (Produit p in listMag.GetMagasinNom(comboMag.SelectedItem.ToString()).ListProd.ListePAR())
                        {
                            ProduitARisque par = (ProduitARisque)p;
                            dataGridRes.Rows.Add(new Object[] { par.Code, par.Nom, par.Prix, par.CatS, par.SousCat, par.TypeR, par.Regles });
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void comboRech_SelectedIndexChanged(object sender, EventArgs e)
        {
            textVal.Enabled = true;
            comboMag.Enabled = true;
            switch (comboRech.SelectedIndex)
            {
                case 0:
                    comboMag.Enabled = false;
                    textVal.Text = "Saisissez l'identifiant du magasin";
                    break;
                case 1:
                    comboMag.Enabled = false;
                    textVal.Text = "Saisissez le code du produit";
                    break;
                case 3:
                    textVal.Text = "Saisissez le code du produit";
                    break;
                case 4:
                    textVal.Text = "Consommable ou NonConsommable";
                    break;
                case 5:
                    textVal.Text = "Saisissez la sous catégorie";
                    break;
                default:
                    textVal.Enabled = false;
                    textVal.Text = "";
                    break;
            }
        }

        private void textVal_Enter(object sender, EventArgs e)
        {
            textVal.Text = "";
        }
    }
}
