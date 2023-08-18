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
    public partial class AjoutMag : Form
    {
        private LesMagasins listMag;

        /// <summary>
        /// Constructeur par défaut de la fenêtre AjoutMag
        /// </summary>
        public AjoutMag()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur avec paramètres de la fenêtre AjoutMag
        /// </summary>
        /// <param name="lst">Liste des magasins transmise par la fenêtre principale</param>
        public AjoutMag(ref LesMagasins lst)
        {
            InitializeComponent();
            listMag = lst;
        }

        private void buttonAnn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVal_Click(object sender, EventArgs e)
        {
            if (textId.Text == "" || textNom.Text == "" || textVille.Text == "" || textTel.Text == "")
            {
                MessageBox.Show("Paramètres invalides");
            }
            else
            {
                listMag.Ajoute(new Magasin(textId.Text, textNom.Text, textVille.Text, textTel.Text));
                this.Close();
            }
        }
    }
}
