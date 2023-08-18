namespace Projet2CDAA
{
    partial class FenPrinc
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnProduitÀRisquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnMagasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.suprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rechercherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.actualiserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeMagProd = new System.Windows.Forms.TreeView();
            this.pictureProd = new System.Windows.Forms.PictureBox();
            this.richDesc = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProd)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnProduitToolStripMenuItem,
            this.ajouterUnProduitÀRisquesToolStripMenuItem,
            this.ajouterUnMagasinToolStripMenuItem,
            this.toolStripSeparator1,
            this.suprimerToolStripMenuItem,
            this.toolStripSeparator2,
            this.rechercherToolStripMenuItem1,
            this.toolStripSeparator3,
            this.actualiserToolStripMenuItem1});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // ajouterUnProduitToolStripMenuItem
            // 
            this.ajouterUnProduitToolStripMenuItem.Name = "ajouterUnProduitToolStripMenuItem";
            this.ajouterUnProduitToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ajouterUnProduitToolStripMenuItem.Text = "Ajouter un produit";
            this.ajouterUnProduitToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnProduitToolStripMenuItem_Click);
            // 
            // ajouterUnProduitÀRisquesToolStripMenuItem
            // 
            this.ajouterUnProduitÀRisquesToolStripMenuItem.Name = "ajouterUnProduitÀRisquesToolStripMenuItem";
            this.ajouterUnProduitÀRisquesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ajouterUnProduitÀRisquesToolStripMenuItem.Text = "Ajouter un produit à risques";
            this.ajouterUnProduitÀRisquesToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnProduitÀRisquesToolStripMenuItem_Click);
            // 
            // ajouterUnMagasinToolStripMenuItem
            // 
            this.ajouterUnMagasinToolStripMenuItem.Name = "ajouterUnMagasinToolStripMenuItem";
            this.ajouterUnMagasinToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ajouterUnMagasinToolStripMenuItem.Text = "Ajouter un magasin";
            this.ajouterUnMagasinToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnMagasinToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // suprimerToolStripMenuItem
            // 
            this.suprimerToolStripMenuItem.Name = "suprimerToolStripMenuItem";
            this.suprimerToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.suprimerToolStripMenuItem.Text = "Suprimer";
            this.suprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(218, 6);
            // 
            // rechercherToolStripMenuItem1
            // 
            this.rechercherToolStripMenuItem1.Name = "rechercherToolStripMenuItem1";
            this.rechercherToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.rechercherToolStripMenuItem1.Text = "Rechercher";
            this.rechercherToolStripMenuItem1.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(218, 6);
            // 
            // actualiserToolStripMenuItem1
            // 
            this.actualiserToolStripMenuItem1.Name = "actualiserToolStripMenuItem1";
            this.actualiserToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.actualiserToolStripMenuItem1.Text = "Actualiser";
            this.actualiserToolStripMenuItem1.Click += new System.EventHandler(this.actualiserToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeMagProd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureProd);
            this.splitContainer1.Panel2.Controls.Add(this.richDesc);
            this.splitContainer1.Size = new System.Drawing.Size(581, 302);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeMagProd
            // 
            this.treeMagProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMagProd.Location = new System.Drawing.Point(0, 0);
            this.treeMagProd.Name = "treeMagProd";
            this.treeMagProd.Size = new System.Drawing.Size(193, 302);
            this.treeMagProd.TabIndex = 0;
            this.treeMagProd.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMagProd_AfterSelect);
            // 
            // pictureProd
            // 
            this.pictureProd.BackColor = System.Drawing.SystemColors.Control;
            this.pictureProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureProd.Location = new System.Drawing.Point(0, 149);
            this.pictureProd.Name = "pictureProd";
            this.pictureProd.Size = new System.Drawing.Size(384, 153);
            this.pictureProd.TabIndex = 1;
            this.pictureProd.TabStop = false;
            // 
            // richDesc
            // 
            this.richDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.richDesc.Location = new System.Drawing.Point(0, 0);
            this.richDesc.Name = "richDesc";
            this.richDesc.Size = new System.Drawing.Size(384, 149);
            this.richDesc.TabIndex = 0;
            this.richDesc.Text = "";
            // 
            // FenPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 326);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FenPrinc";
            this.Text = "Gestion de magasins";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnProduitÀRisquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnMagasinToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeMagProd;
        private System.Windows.Forms.RichTextBox richDesc;
        private System.Windows.Forms.PictureBox pictureProd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem suprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem1;
    }
}

