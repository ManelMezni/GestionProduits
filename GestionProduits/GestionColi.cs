using Controller;
using metiers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProduits
{
    public partial class GestionColi : Form
    {
        public GestionColi()
        {
            InitializeComponent();
        }

        private void GestionColi_Load(object sender, EventArgs e)
        {
            cbPorduit.DataSource = ProduitController.GetProduit().ToArray();
            dgvNewP.DataSource=ColiController.GetColis().ToArray();

        }

        private void btnDao_Click(object sender, EventArgs e)
        {
            Coli c = new Coli(txtReference.Text, dtpDate.Value, Convert.ToInt16(txtQt.Text), (Produit)cbPorduit.SelectedItem);

        }
    }
}
