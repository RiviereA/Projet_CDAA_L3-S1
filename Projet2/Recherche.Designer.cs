namespace Projet2CDAA
{
    partial class Recherche
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
            this.dataGridRes = new System.Windows.Forms.DataGridView();
            this.comboRech = new System.Windows.Forms.ComboBox();
            this.textVal = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboMag = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRech = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRes
            // 
            this.dataGridRes.AllowUserToAddRows = false;
            this.dataGridRes.AllowUserToDeleteRows = false;
            this.dataGridRes.AllowUserToOrderColumns = true;
            this.dataGridRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRes.Location = new System.Drawing.Point(3, 81);
            this.dataGridRes.Name = "dataGridRes";
            this.dataGridRes.ReadOnly = true;
            this.dataGridRes.Size = new System.Drawing.Size(563, 178);
            this.dataGridRes.TabIndex = 0;
            // 
            // comboRech
            // 
            this.comboRech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboRech.FormattingEnabled = true;
            this.comboRech.Location = new System.Drawing.Point(3, 3);
            this.comboRech.Name = "comboRech";
            this.comboRech.Size = new System.Drawing.Size(563, 21);
            this.comboRech.TabIndex = 1;
            this.comboRech.SelectedIndexChanged += new System.EventHandler(this.comboRech_SelectedIndexChanged);
            // 
            // textVal
            // 
            this.textVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textVal.Location = new System.Drawing.Point(3, 29);
            this.textVal.Name = "textVal";
            this.textVal.Size = new System.Drawing.Size(563, 20);
            this.textVal.TabIndex = 3;
            this.textVal.Enter += new System.EventHandler(this.textVal_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.comboRech, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textVal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridRes, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(569, 262);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboMag);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonRech);
            this.splitContainer1.Size = new System.Drawing.Size(563, 20);
            this.splitContainer1.SplitterDistance = 446;
            this.splitContainer1.TabIndex = 4;
            // 
            // comboMag
            // 
            this.comboMag.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboMag.FormattingEnabled = true;
            this.comboMag.Location = new System.Drawing.Point(116, 0);
            this.comboMag.Name = "comboMag";
            this.comboMag.Size = new System.Drawing.Size(330, 21);
            this.comboMag.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magasin sélectionné :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonRech
            // 
            this.buttonRech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRech.Location = new System.Drawing.Point(0, 0);
            this.buttonRech.Name = "buttonRech";
            this.buttonRech.Size = new System.Drawing.Size(113, 20);
            this.buttonRech.TabIndex = 3;
            this.buttonRech.Text = "Rechercher";
            this.buttonRech.UseVisualStyleBackColor = true;
            this.buttonRech.Click += new System.EventHandler(this.buttonRech_Click);
            // 
            // Recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Recherche";
            this.Text = "Recherche";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRes;
        private System.Windows.Forms.ComboBox comboRech;
        private System.Windows.Forms.TextBox textVal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboMag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRech;
    }
}