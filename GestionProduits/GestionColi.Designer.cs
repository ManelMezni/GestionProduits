namespace GestionProduits
{
    partial class GestionColi
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
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.cbPorduit = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNewP
            // 
            this.dgvNewP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewP.Location = new System.Drawing.Point(459, 67);
            this.dgvNewP.Name = "dgvNewP";
            this.dgvNewP.RowHeadersWidth = 51;
            this.dgvNewP.RowTemplate.Height = 24;
            this.dgvNewP.Size = new System.Drawing.Size(576, 149);
            this.dgvNewP.TabIndex = 31;
            // 
            // btnDao
            // 
            this.btnDao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDao.Location = new System.Drawing.Point(303, 383);
            this.btnDao.Name = "btnDao";
            this.btnDao.Size = new System.Drawing.Size(187, 44);
            this.btnDao.TabIndex = 30;
            this.btnDao.Text = "aj avec dao";
            this.btnDao.UseVisualStyleBackColor = true;
            this.btnDao.Click += new System.EventHandler(this.btnDao_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(879, 384);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(121, 44);
            this.btnModifier.TabIndex = 29;
            this.btnModifier.Text = "modif";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupp
            // 
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.Location = new System.Drawing.Point(711, 384);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(121, 44);
            this.btnSupp.TabIndex = 28;
            this.btnSupp.Text = "supp";
            this.btnSupp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "produit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "qt";
            // 
            // txtQt
            // 
            this.txtQt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQt.Location = new System.Drawing.Point(202, 182);
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(202, 34);
            this.txtQt.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "des";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "ref";
            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Location = new System.Drawing.Point(202, 63);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(202, 34);
            this.txtReference.TabIndex = 19;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(62, 383);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(198, 45);
            this.btnRecherche.TabIndex = 18;
            this.btnRecherche.Text = "recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            // 
            // cbPorduit
            // 
            this.cbPorduit.FormattingEnabled = true;
            this.cbPorduit.Location = new System.Drawing.Point(230, 254);
            this.cbPorduit.Name = "cbPorduit";
            this.cbPorduit.Size = new System.Drawing.Size(121, 24);
            this.cbPorduit.TabIndex = 32;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(192, 131);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 33;
            // 
            // GestionColi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 536);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbPorduit);
            this.Controls.Add(this.dgvNewP);
            this.Controls.Add(this.btnDao);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.btnRecherche);
            this.Name = "GestionColi";
            this.Text = "GestionColi";
            this.Load += new System.EventHandler(this.GestionColi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNewP;
        private System.Windows.Forms.Button btnDao;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.ComboBox cbPorduit;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}