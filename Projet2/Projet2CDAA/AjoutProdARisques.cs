using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2CDAA
{
    public partial class AjoutProdARisques : Form
    {
        private LesMagasins listMag;

        /// <summary>
        /// Constructeur par défaut de la fenêtre AjoutProdARisques
        /// </summary>
        public AjoutProdARisques()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur avec paramètres de la fenêtre AjoutProdARisques
        /// </summary>
        /// <param name="lst">Liste des magasins transmise par la fenêtre principale</param>
        public AjoutProdARisques(ref LesMagasins lst)
        {
            InitializeComponent();
            listMag = lst;
            comboCat.Items.Add("Consommable");
            comboCat.Items.Add("NonConsommable");
            foreach (Magasin m in listMag.ListMag) comboMag.Items.Add(m.Nom);
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textImage.Text = openFileDialog1.FileName;
            }
        }

        private void buttonAnn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVal_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboMag.SelectedItem.ToString() == "" || textCode.Text == "" || textNom.Text == "" || textPrix.Text == "" || comboCat.SelectedItem.ToString() == "" || textSCat.Text == "" || textImage.Text == "" || textTRisques.Text == "" || richRegles.Text == "")
                {
                    MessageBox.Show("Paramètres invalides");
                }
                else
                {
                    Image img = Image.FromFile(Path.GetFullPath(textImage.Text));
                    listMag.GetMagasinNom(comboMag.SelectedItem.ToString()).ListProd.Ajoute(new ProduitARisque(Int32.Parse(textCode.Text), textNom.Text, Double.Parse(textPrix.Text), (Categorie)Enum.Parse(typeof(Categorie), comboCat.SelectedItem.ToString(), false), textSCat.Text, img, textTRisques.Text, richRegles.Text));
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
