using metiers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dao;

namespace dao
{
    public class ColiDAO
    {
        static SqlConnection cnx;
        public static void Add(Coli p)
        {
            try
            {
                 cnx = Connexionvente.GetInstance();

                String reqSQL = "insert into tColis values (@numero, @dateLiv, @qtecol, @produit)";
                SqlCommand cmd = new SqlCommand(reqSQL, cnx);

                cmd.Parameters.Add("@numero", p.Numero);
                cmd.Parameters.Add("@dateLiv", p.DateLiv);
                cmd.Parameters.Add("@qtecol", p.Qtecol);
                cmd.Parameters.Add("@produit", p.Produit.Reference);
                int nbr = cmd.ExecuteNonQuery();
                if (nbr != 0)
                {
                    MessageBox.Show("done");
                }


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
                cnx = Connexionvente.GetInstance();


                string reqSQL = "DELETE FROM tProduit WHERE numero = @num";

                SqlCommand cmd = new SqlCommand(reqSQL, cnx);
                cmd.Parameters.Add("@num", text);

                int lignesAffectees = cmd.ExecuteNonQuery();

                if (lignesAffectees != 0)
                {
                    MessageBox.Show($"coli {text} supprimé !");
                }
                else
                    MessageBox.Show("Aucun coli trouvé avec cette référence.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }
        public static List<Coli> FindAll()
        {
            List<Coli> lesColis = new List<Coli>();

            try
            {
                 cnx = Connexionvente.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from tColis", cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    List<Produit> produits = ProduitDAO.FindAll();
                    Produit p = null;
                    foreach (Produit pr in produits)
                    {
                        if (pr.Reference.Equals(dr.GetString(3)))
                        {
                            p = pr;
                            break;
                        }
                    }
                    Coli c = new Coli(dr.GetString(0), dr.GetDateTime(1), dr.GetInt32(2), p);

                    lesColis.Add(c);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                cnx.Close();
            }

            return lesColis;
        }
       
    
        public static void Update(Coli p)
        {
            try
            {

                 cnx = Connexionvente.GetInstance();



                string reqSQL = @"UPDATE tColis 
                         SET dateLiv = @date, 
                             qtecol = @qte, 
                             produit = @pr 
                         WHERE numero = @num";

                SqlCommand cmd = new SqlCommand(reqSQL, cnx);

                cmd.Parameters.Add("@num", p.Numero);
                cmd.Parameters.Add("@dateLiv", p.DateLiv);
                cmd.Parameters.Add("@qtecol", p.Qtecol);
                cmd.Parameters.Add("@produit", p.Produit.Reference);

                int lignesAffectees = cmd.ExecuteNonQuery();



                if (lignesAffectees > 0)
                {
                    MessageBox.Show($"coli {p.Numero} modifié avec succès !");

                }
                else
                {
                    MessageBox.Show("Aucun coli modifié. Vérifiez la référence.");
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Erreur SQL : " + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }
    }
}
