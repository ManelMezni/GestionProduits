namespace GestionProduits
{
    partial class GestionProduit
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
            this.btnRecherche = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnDao = new System.Windows.Forms.Button();
            this.dgvNewP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(22, 361);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(198, 45);
            this.btnRecherche.TabIndex = 0;
            this.btnRecherche.Text = "recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "des";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "ref";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.Location = new System.Drawing.Point(162, 103);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(202, 34);
            this.txtDesignation.TabIndex = 5;
            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Location = new System.Drawing.Point(162, 41);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(202, 34);
            this.txtReference.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "qt";
            // 
            // txtPrix
            // 
            this.txtPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.Location = new System.Drawing.Point(162, 222);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(202, 34);
            this.txtPrix.TabIndex = 9;
            // 
            // txtQt
            // 
            this.txtQt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQt.Location = new System.Drawing.Point(162, 160);
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(202, 34);
            this.txtQt.TabIndex = 8;
            // 
            // dgvProduits
            // 
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvProduits.Location = new System.Drawing.Point(408, 12);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.RowHeadersWidth = 51;
            this.dgvProduits.RowTemplate.Height = 24;
            this.dgvProduits.Size = new System.Drawing.Size(576, 150);
            this.dgvProduits.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ref";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "des";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "qt";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "prix";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // btnSupp
            // 
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.Location = new System.Drawing.Point(671, 362);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(121, 44);
            this.btnSupp.TabIndex = 14;
            this.btnSupp.Text = "supp";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(839, 362);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(121, 44);
            this.btnModifier.TabIndex = 15;
            this.btnModifier.Text = "modif";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click_1);
            // 
            // btnDao
            // 
            this.btnDao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDao.Location = new System.Drawing.Point(263, 361);
            this.btnDao.Name = "btnDao";
            this.btnDao.Size = new System.Drawing.Size(187, 44);
            this.btnDao.TabIndex = 16;
            this.btnDao.Text = "aj avec dao";
            this.btnDao.UseVisualStyleBackColor = true;
            this.btnDao.Click += new System.EventHandler(this.btnDao_Click);
            // 
            // dgvNewP
            // 
            this.dgvNewP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewP.Location = new System.Drawing.Point(408, 177);
            this.dgvNewP.Name = "dgvNewP";
            this.dgvNewP.RowHeadersWidth = 51;
            this.dgvNewP.RowTemplate.Height = 24;
            this.dgvNewP.Size = new System.Drawing.Size(576, 149);
            this.dgvNewP.TabIndex = 17;
            // 
            // GestionProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 503);
            this.Controls.Add(this.dgvNewP);
            this.Controls.Add(this.btnDao);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.dgvProduits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtQt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.btnRecherche);
            this.Name = "GestionProduit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnDao;
        private System.Windows.Forms.DataGridView dgvNewP;
    }
}

