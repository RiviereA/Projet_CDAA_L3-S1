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
    public partial class Suppression : Form
    {
        private LesMagasins listMag;

        /// <summary>
        /// Constructeur par défaut de la fenêtre Suppression
        /// </summary>
        public Suppression()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur avec paramètres de la fenêtre Suppression
        /// </summary>
        /// <param name="lst">Liste des magasins transmise par la fenêtre principale</param>
        public Suppression(ref LesMagasins lst)
        {
            InitializeComponent();
            listMag = lst;
            Actualise();
        }

        /// <summary>
        /// Méthode actualisant les données dans la fenêtre
        /// </summary>
        public void Actualise()
        {
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

        private void treeMagProd_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeMagProd.SelectedNode.Parent == null)
            {
                richMagProd.Text = listMag.GetMagasinNom(treeMagProd.SelectedNode.Text).ToString();
            }
            else
            {
                richMagProd.Text = listMag.GetMagasinNom(treeMagProd.SelectedNode.Parent.Text).ListProd.GetProduitNom(treeMagProd.SelectedNode.Text).ToString();
            }
        }

        private void buttonAnn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSupr_Click(object sender, EventArgs e)
        {
            Console.WriteLine(treeMagProd.SelectedNode.Text);
            if (treeMagProd.SelectedNode.Parent == null)
            {
                listMag.Supprime(listMag.GetMagasinNom(treeMagProd.SelectedNode.Text));
            }
            else
            {
                Produit p = listMag.GetMagasinNom(treeMagProd.SelectedNode.Parent.Text).ListProd.GetProduitNom(treeMagProd.SelectedNode.Text);
                listMag.GetMagasinNom(treeMagProd.SelectedNode.Parent.Text).ListProd.Supprime(p);
            }
            Actualise();
        }
    }
}
