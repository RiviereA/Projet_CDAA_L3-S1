namespace Projet2CDAA
{
    partial class Suppression
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonAnn = new System.Windows.Forms.Button();
            this.treeMagProd = new System.Windows.Forms.TreeView();
            this.buttonSupr = new System.Windows.Forms.Button();
            this.richMagProd = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonAnn);
            this.splitContainer1.Panel1.Controls.Add(this.treeMagProd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonSupr);
            this.splitContainer1.Panel2.Controls.Add(this.richMagProd);
            this.splitContainer1.Size = new System.Drawing.Size(284, 262);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonAnn
            // 
            this.buttonAnn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAnn.Location = new System.Drawing.Point(0, 239);
            this.buttonAnn.Name = "buttonAnn";
            this.buttonAnn.Size = new System.Drawing.Size(137, 23);
            this.buttonAnn.TabIndex = 1;
            this.buttonAnn.Text = "Annuler";
            this.buttonAnn.UseVisualStyleBackColor = true;
            this.buttonAnn.Click += new System.EventHandler(this.buttonAnn_Click);
            // 
            // treeMagProd
            // 
            this.treeMagProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeMagProd.Location = new System.Drawing.Point(0, 0);
            this.treeMagProd.Name = "treeMagProd";
            this.treeMagProd.Size = new System.Drawing.Size(137, 233);
            this.treeMagProd.TabIndex = 0;
            this.treeMagProd.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMagProd_AfterSelect);
            // 
            // buttonSupr
            // 
            this.buttonSupr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSupr.Location = new System.Drawing.Point(0, 239);
            this.buttonSupr.Name = "buttonSupr";
            this.buttonSupr.Size = new System.Drawing.Size(143, 23);
            this.buttonSupr.TabIndex = 1;
            this.buttonSupr.Text = "Supprimer";
            this.buttonSupr.UseVisualStyleBackColor = true;
            this.buttonSupr.Click += new System.EventHandler(this.buttonSupr_Click);
            // 
            // richMagProd
            // 
            this.richMagProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.richMagProd.Location = new System.Drawing.Point(0, 0);
            this.richMagProd.Name = "richMagProd";
            this.richMagProd.Size = new System.Drawing.Size(143, 233);
            this.richMagProd.TabIndex = 0;
            this.richMagProd.Text = "";
            // 
            // Suppression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Suppression";
            this.Text = "Suppression";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeMagProd;
        private System.Windows.Forms.RichTextBox richMagProd;
        private System.Windows.Forms.Button buttonAnn;
        private System.Windows.Forms.Button buttonSupr;
    }
}