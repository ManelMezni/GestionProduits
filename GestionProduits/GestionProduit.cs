using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using metiers;
using dao;

namespace GestionProduits
{
    public partial class GestionProduit : Form
    {
        public GestionProduit()
        {
            InitializeComponent();
           

        }

       public static List<Produit> lesPorduits ;
        private void btnRecherche_Click(object sender, EventArgs e)
        {

            Produit m = ProduitDAO.Find(txtReference.Text);

                if (m != null)
                {
                    txtReference.Text = m.Reference;
                    txtDesignation.Text = m.Designation;
                    txtPrix.Text = m.PrixAchat.ToString();
                    txtQt.Text = m.Quantite.ToString();

                    MessageBox.Show("produit trouvé !");
                }
                else
                {
                    MessageBox.Show("produit non trouvé !");
                    ViderChamps();
                }
         
        }

        


        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (txtReference.Text=="")
            {
                MessageBox.Show("Veuillez entrer une référence !");
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                "Voulez-vous vraiment supprimer le produit "+txtReference.Text,
                "Confirmation",
                MessageBoxButtons.YesNo
              
            );

            if (confirmation != DialogResult.Yes)
                return;
            ProduitDAO.Delete(txtReference.Text);
            Produit_Load(sender, e);


        }

        private void ViderChamps()
        {
            txtReference.Text = "";
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (txtReference.Text=="")
            {
                MessageBox.Show("Veuillez entchercher d'abord un produit à modifier !");
                return;
            }

          
           

        }

        private void Produit_Load(object sender, EventArgs e)
        {
               dgvProduits.Rows.Clear();

            lesPorduits = ProduitController.GetProduit();
            foreach (Produit p in lesPorduits)
            {
                dgvProduits.Rows.Add(p.Reference, p.Designation, p.PrixAchat, p.Quantite);
            }
            dgvNewP.DataSource = lesPorduits;

            }

        private void btnDao_Click(object sender, EventArgs e)
        {
            Produit pr=new Produit(txtReference.Text, txtDesignation.Text, Convert.ToInt32(txtQt.Text), Convert.ToDouble(txtPrix.Text));
            if (lesPorduits.Contains(pr))
            {
                MessageBox.Show("already");
            }
            else
            {
                ProduitDAO.Add(pr);
                Produit_Load(sender, e);
                ViderChamps();
            }
                

        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            if (txtReference.Text=="")
            {
                MessageBox.Show("Veuillez entchercher d'abord un produit à modifier !");
                return;
            }
            Produit pr = new Produit(txtReference.Text, txtDesignation.Text, Convert.ToInt32(txtQt.Text), Convert.ToDouble(txtPrix.Text));

            //Produit p = ProduitDAO.Find(txtReference.Text);
            ProduitDAO.Update(pr);

  
            
        }

        private void btnRecherche_Click_1(object sender, EventArgs e)
        {

        }




        //findall b3d find by bech na9s l sql 
        //dao anglais 
        //controler francais
        //list static fil load bech b3d man93dch naccedy lil base de donne 
    }
}
