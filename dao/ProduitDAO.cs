using dao;
using metiers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace metiers
{
    public class ProduitDAO
    {
        //tjm tsir bool
        public static void Add(Produit p)
        {
            try
            {
                //string url = @"Server=DESKTOP-5DK0TQB\SQLEXPRESS;Database=BDCommerciale;Trusted_Connection=True";
                SqlConnection cnx = Connexionvente.GetInstance();// new SqlConnection(url);
                                                                 // cnx.Open();
                String reqSQL = "insert into tProduit values (@refe, @desig, @quantite, @prix)";
                SqlCommand cmd = new SqlCommand(reqSQL, cnx);

               // Produit p = new Produit(txtReference.Text, txtDesignation.Text, Convert.ToInt32(txtQt.Text),double.Parse(txtPrix.Text));
                cmd.Parameters.Add("@refe", p.Reference);
                cmd.Parameters.Add("@desig", p.Designation);
                cmd.Parameters.Add("@quantite", p.Quantite);
                cmd.Parameters.Add("@prix", p.PrixAchat);
                int nbr = cmd.ExecuteNonQuery();
                if (nbr != 0)
                {
                    MessageBox.Show("done");
                }
                cnx.Close();


            }
            catch (SqlException ex)
            { 
                MessageBox.Show("L’erreur dans l’ajout" + ex.Message);
            }

        }
        public static void Delete(String text)
        {
            try
            {
                SqlConnection cnx = Connexionvente.GetInstance();
                

                // REQUÊTE DELETE PARAMÉTRÉE
                string reqSQL = "DELETE FROM tProduit WHERE reference = @ref";

                SqlCommand cmd = new SqlCommand(reqSQL, cnx);
                cmd.Parameters.Add("@ref", text);

                int lignesAffectees = cmd.ExecuteNonQuery();

                if (lignesAffectees != 0)
                {
                    MessageBox.Show($"Produit {text} supprimé !");
                }
                else
                    MessageBox.Show("Aucun produit trouvé avec cette référence.");
                cnx.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
        public static List<Produit> FindAll()
        {
            List<Produit> lesProduits = new List<Produit>();
          
            try
            {
                SqlConnection cnx = Connexionvente.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from tproduit", cnx);
                SqlDataReader dr =cmd.ExecuteReader();
                while (dr.Read())
                {
                    //cas complexe cles etrangere
                    //coli til9aha fih l cle tjibo bech nara l produit 
                    Produit p = new Produit(dr.GetString(0),dr.GetString(1),dr.GetInt32(2),dr.GetFloat(3));
                    /*
                     *  dr[0].ToString(),  
                            dr[1].ToString(),  
                            dr[2].ToString(),  
                            dr[3].ToString()   
                    */
                    lesProduits.Add(p);
                }
                cnx.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
           
            return lesProduits;
        }
        public static Produit Find(string refe)
        {
            try
            {
                SqlConnection cnx = Connexionvente.GetInstance();
                string requete = "SELECT * FROM tproduit WHERE reference = @ref";

                SqlCommand commande = new SqlCommand(requete, cnx);
                commande.Parameters.Add("@ref", refe);
                SqlDataReader dr = commande.ExecuteReader();

                if (dr.Read())
                {
                    Produit p = new Produit(dr.GetString(0), dr.GetString(1), dr.GetInt32(2), dr.GetFloat(3));
                    MessageBox.Show("trouver");
                    return p;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur SQL (Find): " + ex.Message);
            }

            return null;


        }
        public static void Update(Produit p)
        {
            try
            {

                SqlConnection cnx = Connexionvente.GetInstance();



                // On modifie tout SAUF la référence (clé primaire)
                string reqSQL = @"UPDATE tProduit 
                         SET designation = @des, 
                             quantite = @qte, 
                             prixAchat = @prix 
                         WHERE reference = @ref";

                SqlCommand cmd = new SqlCommand(reqSQL, cnx);

                cmd.Parameters.Add("@ref", p.Reference);
                cmd.Parameters.Add("@des", p.Designation);
                cmd.Parameters.Add("@qte", p.Quantite);
                cmd.Parameters.Add("@prix", p.PrixAchat);

                int lignesAffectees = cmd.ExecuteNonQuery();

                

                if (lignesAffectees > 0)
                {
                    MessageBox.Show($"Produit {p.Reference} modifié avec succès !");

                }
                else
                {
                    MessageBox.Show("Aucun produit modifié. Vérifiez la référence.");
                }
                cnx.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Erreur SQL : " + ex.Message);
            }
        }

    }
    //update where selon cle primaire also fil deleete 
    //execute reader yraj3 data reader reader t9adem matwa5rch 
    //getfloat and not double
    //
/*
 * string message = $"Nombre de produits trouvés : {listeProduits.Count}\n\n";

            foreach (Produit p in listeProduits)
            {
                message += $"{p.Reference} | {p.Designation} | {p.Quantite} | {p.PrixAchat}\n";
            }

            MessageBox.Show(message, "Liste des produits");
*/

}

