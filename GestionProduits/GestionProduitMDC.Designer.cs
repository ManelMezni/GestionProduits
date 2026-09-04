namespace GestionProduits
{
    partial class GestionProduitMDC
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
            this.dgvNewP = new System.Windows.Forms.DataGridView();
            this.btnDao = new System.Windows.Forms.Button();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnchercher = new System.Windows.Forms.Button();
            this.dgvProduitLINQ = new System.Windows.Forms.DataGridView();
            this.btnChercherPrix = new System.Windows.Forms.Button();
            this.dgvProduitLinqDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitLINQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitLinqDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNewP
            // 
            this.dgvNewP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewP.Location = new System.Drawing.Point(322, 195);
            this.dgvNewP.Name = "dgvNewP";
            //this.dgvNewP.RowHeadersWidth = 51;
            this.dgvNewP.RowTemplate.Height = 24;
            this.dgvNewP.Size = new System.Drawing.Size(576, 149);
            this.dgvNewP.TabIndex = 31;
            //this.dgvNewP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewP_CellContentClick);
            // 
            // btnDao
            // 
            this.btnDao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDao.Location = new System.Drawing.Point(223, 383);
            this.btnDao.Name = "btnDao";
            this.btnDao.Size = new System.Drawing.Size(187, 44);
            this.btnDao.TabIndex = 30;
            this.btnDao.Text = "ajouter";
            this.btnDao.UseVisualStyleBackColor = true;
            this.btnDao.Click += new System.EventHandler(this.btnDao_Click);
            // 
            // dgvProduits
            // 
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvProduits.Location = new System.Drawing.Point(322, 14);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.RowHeadersWidth = 51;
            this.dgvProduits.RowTemplate.Height = 24;
            this.dgvProduits.Size = new System.Drawing.Size(576, 150);
            this.dgvProduits.TabIndex = 27;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-66, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-66, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "qt";
            // 
            // txtPrix
            // 
            this.txtPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.Location = new System.Drawing.Point(114, 237);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(202, 34);
            this.txtPrix.TabIndex = 24;
            // 
            // txtQt
            // 
            this.txtQt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQt.Location = new System.Drawing.Point(114, 175);
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(202, 34);
            this.txtQt.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-66, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "des";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-66, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "ref";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.Location = new System.Drawing.Point(114, 118);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(202, 34);
            this.txtDesignation.TabIndex = 20;
            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Location = new System.Drawing.Point(114, 56);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(202, 34);
            this.txtReference.TabIndex = 19;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(-3, 383);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(198, 45);
            this.btnEnregistrer.TabIndex = 18;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "prix";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = "qt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "des";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "ref";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(431, 384);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(187, 44);
            this.btnSupprimer.TabIndex = 36;
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(624, 384);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(187, 44);
            this.btnModifier.TabIndex = 37;
            this.btnModifier.Text = "modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnchercher
            // 
            this.btnchercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchercher.Location = new System.Drawing.Point(817, 384);
            this.btnchercher.Name = "btnchercher";
            this.btnchercher.Size = new System.Drawing.Size(246, 44);
            this.btnchercher.TabIndex = 38;
            this.btnchercher.Text = "chercher par Produit";
            this.btnchercher.UseVisualStyleBackColor = true;
            this.btnchercher.Click += new System.EventHandler(this.btnchercher_Click);
            // 
            // dgvProduitLINQ
            // 
            this.dgvProduitLINQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduitLINQ.Location = new System.Drawing.Point(904, 229);
            this.dgvProduitLINQ.Name = "dgvProduitLINQ";
            this.dgvProduitLINQ.RowHeadersWidth = 51;
            this.dgvProduitLINQ.RowTemplate.Height = 24;
            this.dgvProduitLINQ.Size = new System.Drawing.Size(573, 115);
            this.dgvProduitLINQ.TabIndex = 39;
            // 
            // btnChercherPrix
            // 
            this.btnChercherPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercherPrix.Location = new System.Drawing.Point(1069, 383);
            this.btnChercherPrix.Name = "btnChercherPrix";
            this.btnChercherPrix.Size = new System.Drawing.Size(238, 44);
            this.btnChercherPrix.TabIndex = 40;
            this.btnChercherPrix.Text = "chercher pas prix";
            this.btnChercherPrix.UseVisualStyleBackColor = true;
            this.btnChercherPrix.Click += new System.EventHandler(this.btnChercherPrix_Click);
            // 
            // dgvProduitLinqDataTable
            // 
            this.dgvProduitLinqDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduitLinqDataTable.Location = new System.Drawing.Point(904, 37);
            this.dgvProduitLinqDataTable.Name = "dgvProduitLinqDataTable";
            this.dgvProduitLinqDataTable.RowHeadersWidth = 51;
            this.dgvProduitLinqDataTable.RowTemplate.Height = 24;
            this.dgvProduitLinqDataTable.Size = new System.Drawing.Size(573, 115);
            this.dgvProduitLinqDataTable.TabIndex = 41;
            // 
            // GestionProduitMDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 496);
            this.Controls.Add(this.dgvProduitLinqDataTable);
            this.Controls.Add(this.btnChercherPrix);
            this.Controls.Add(this.dgvProduitLINQ);
            this.Controls.Add(this.btnchercher);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvNewP);
            this.Controls.Add(this.btnDao);
            this.Controls.Add(this.dgvProduits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtQt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.btnEnregistrer);
            this.Name = "GestionProduitMDC";
            this.Text = "GestionProduitMDC";
            this.Load += new System.EventHandler(this.GestionProduitMDC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitLINQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitLinqDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNewP;
        private System.Windows.Forms.Button btnDao;
        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnchercher;
        private System.Windows.Forms.DataGridView dgvProduitLINQ;
        private System.Windows.Forms.Button btnChercherPrix;
        private System.Windows.Forms.DataGridView dgvProduitLinqDataTable;
    }
}