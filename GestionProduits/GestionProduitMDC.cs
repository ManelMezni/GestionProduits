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
using dao;

namespace GestionProduits
{
    //fil lecture mdc sinon fil update w l kol mc orm object relation mapping
    public partial class GestionProduitMDC : Form
    {
        public GestionProduitMDC()
        {
            InitializeComponent();
        }

    private void GestionProduitMDC_Load(object sender, EventArgs e)
        {
            //DataTable dt = VenteMDC.ChargerProduits();
            //dgvNewP.DataSource = dt;
            dgvNewP.DataSource = null;
            dgvNewP.DataSource = VenteMDC.GetProduits().ToArray();

            /*
            dgvProduits.Rows.Clear();          
            // Parcourir les lignes du DataTable
            foreach (DataRow ligne in dt.Rows)
            {
                dgvProduits.Rows.Add(
                    ligne[0],  
                    ligne[1],  
                    ligne[2],  
                    ligne[3]   
                );
            }*/

            //where dima condition traj3 true wala false
            //njm n3ml select p ama la partie w bara

            /*
             * foreach (Produit p in VenteMDC.GetProduits())
              {  
                // p = un produit à la fois
            dgvProduits.Rows.Add(p.immat,..)
            
                }*/


            var LesProdsPC = from p in VenteMDC.GetProduits()

                             // where p.Designation.Contains("pc".ToLower())
                             where p.Designation.ToLower().Contains("pc")
                             select new { Dr =p.Designation ,
                              p.Quantite,
                              prixAchat=p.PrixAchat,
                              prixVente=p.PrixAchat*2
                          };
            var lesProdss = from pd in VenteMDC.ChargerProduits().AsEnumerable()
                            where pd.Field<String>(1).Contains("pc")
                            select new
                            {
                                des = pd.Field<String>(1),
                                qt = pd.Field<int>(2),
                                PrixVente = pd.Field<float>(3) * 1.2,
                            };

            dgvProduitLINQ.DataSource = lesProdss.ToList();


            //sur  fil examen
            DataTable dt = VenteMDC.dsVente.Tables["TLProduit"];
            if (dt==null)
                dt= VenteMDC.ChargerProduits();

            var LesProdsDT = from lignProd in dt.AsEnumerable()
                             where lignProd.Field<String>(1).Contains("pc")
                             select new
                             {
                                 Degs = lignProd.Field<String>(1),
                                 Qte= lignProd.Field<int>(2),
                                 prixAchat = lignProd.Field<float>(3),
                                 prixVente = lignProd.Field<float>(3)*2
                             };
            dgvProduitLinqDataTable.DataSource = LesProdsDT.ToList();
        }


        private void btnDao_Click(object sender, EventArgs e)
        {
            Produit p = new Produit(txtReference.Text,txtDesignation.Text,int.Parse(txtQt.Text),double.Parse(txtPrix.Text));
            if (VenteMDC.GetProduits().Contains(p))
            {
                MessageBox.Show("produit existe deja");
            }
            else
            {
               // VenteMDC.AjouterProduit(p);               
                // dgvProduits.Rows.Add(p.Reference, p.Designation, p.Quantite, p.PrixAchat);
                dgvNewP.DataSource = VenteMDC.AjouterProduit(p);
                MessageBox.Show("produit ajouter");

            }
         

        }
        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("enregistrer???", "ATT", MessageBoxButtons.YesNo);
            if (choix == DialogResult.Yes)
            {
                //njm direct VenteMDC.EnregistrerProduit()
                if (VenteMDC.EnregistrerProduit())
                    MessageBox.Show("c bon enregistrer ");
                else
                    MessageBox.Show("non enregistrer ");
               GestionProduitMDC_Load(sender, e);
            }

        }


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("supprimer???", "ATT", MessageBoxButtons.YesNo);
            if (choix == DialogResult.Yes)
            {       
                DataTable dt= VenteMDC.SupprimerProduit(txtReference.Text);
                 if (VenteMDC.EnregistrerProduit())
                    MessageBox.Show("c bon supprimer ");

                dgvNewP.DataSource = dt;
                //waala bi rows
                dgvProduits.Rows.Clear();
                foreach (DataRow ligne in dt.Rows)
                {
                    dgvProduits.Rows.Add(
                        ligne[0],
                        ligne[1],
                        ligne[2],
                        ligne[3]
                    );
                }
               
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Produit p = new Produit(txtReference.Text, txtDesignation.Text, int.Parse(txtQt.Text), double.Parse(txtPrix.Text));
            dgvNewP.DataSource = VenteMDC.ModifierProduit(p);
        }

        private void btnchercher_Click(object sender, EventArgs e)
        {
            Produit p = new Produit(txtReference.Text, "", 0, 0);
            if (VenteMDC.GetProduits().Contains(p))
            {
                MessageBox.Show("produit existe deja");
            }
            else
            {
                MessageBox.Show("produit n'existe pas");
            }
        }
        private void btnChercherPrix_Click(object sender, EventArgs e)
        {
            DataTable dt = VenteMDC.dsVente.Tables["TLProduit"];
            var prix = Convert.ToDouble(txtPrix.Text);
            var LesProdsPC = from p in dt.AsEnumerable()
                             where p.Field<float>(3) == prix
                               select new
                                {
                                    Desg = p.Field<String>(1),
                                    Qte= p.Field<int>(2),
                                    prixVente = Math.Round(p.Field<float>(3) * 1.3, 2)
                                };
                                // select p;
               dgvProduitLINQ.DataSource = LesProdsPC.ToList();
        }
    }
    }
