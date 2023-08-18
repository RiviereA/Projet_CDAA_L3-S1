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
    public partial class FenPrinc : Form
    {
        private LesMagasins listMag; // Liste des magasins

        /// <summary>
        /// Constructeur par défaut de la fenêtre principale
        /// </summary>
        public FenPrinc()
        {
            InitializeComponent();
            listMag = new LesMagasins();
            listMag.Ajoute(new Magasin("1", "Marché", "Dijon", "0385010101"));
            listMag.GetMagasin("1").RemplirMagasin();
            this.Actualise();
        }

        /// <summary>
        /// Méthode actualisant les données dans la fenêtre principale
        /// </summary>
        public void Actualise()
        {
            richDesc.Text = "";
            pictureProd.Image = null;
            treeMagProd.Nodes.Clear();
            int i = 0;
            foreach (Magasin m in listMag.ListMag)
            {
                treeMagProd.Nodes.Add(m.Nom);
                foreach (Produit p in m.ListProd.ListProd)
                {
                    treeMagProd.Nodes[i].Nodes.Add(p.Nom);
                }
                i++;
            }
        }

        private void ajouterUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutProd fen = new AjoutProd(ref listMag);
            fen.Show();
        }

        private void ajouterUnProduitÀRisquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutProdARisques fen = new AjoutProdARisques(ref listMag);
            fen.Show();
        }

        private void ajouterUnMagasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutMag fen = new AjoutMag(ref listMag);
            fen.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppression fen = new Suppression(ref listMag);
            fen.Show();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recherche fen = new Recherche(ref listMag);
            fen.Show();
        }

        private void treeMagProd_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pictureProd.Image = null;
            if (treeMagProd.SelectedNode.Parent == null)
            {
                richDesc.Text = listMag.GetMagasinNom(treeMagProd.SelectedNode.Text).ToString();
            }
            else
            {
                richDesc.Text = listMag.GetMagasinNom(treeMagProd.SelectedNode.Parent.Text).ListProd.GetProduitNom(treeMagProd.SelectedNode.Text).ToString();

                pictureProd.Image = (Image)(new Bitmap(listMag.GetMagasinNom(treeMagProd.SelectedNode.Parent.Text).ListProd.GetProduitNom(treeMagProd.SelectedNode.Text).Img, new Size(pictureProd.Width, pictureProd.Height)));
            }
        }

        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualise();
        }
    }
}
