using metiers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dao
{
   public  class VenteMDC
        //ajouter modifier supprimer chercher pas de connexion
        //cnx ken  fi charger et enregistrer
    {
       public static DataSet dsVente = new DataSet(); // la BDL
        static SqlDataAdapter da;
        //ajouter fil data table deja charger
    
        public static DataTable ChargerProduits()
        {
            DataTable dtProds = null;
            SqlConnection cnx = null;
            try
            {
                cnx = Connexionvente.GetInstance();
                // Etape 2 : création du DataAdapter
                da = new SqlDataAdapter("select * from tProduit", cnx);
                //ou bill null ? 
                if (dsVente.Tables.Contains("TLProduit"))
                {
                    dsVente.Tables["TLProduit"].Clear();
                }
                // Etape 3 : chargement de la table dans la BDL
                da.Fill(dsVente, "TLProduit");

                dtProds = dsVente.Tables["TLProduit"];

                cnx.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur chargement : " + ex.Message);
                cnx.Close();
            }
           
            // Etape 5 : retourner le DataTable chargé
            return dtProds;
        }

        /*
           public static void AjouterProduit(Produit p)
           {
               // Etape 1 : choisir la table dans le DataSet
               //ili deja chargito fi charger
               DataTable dt = dsVente.Tables["TLProduit"];

               // Etape 2 : créer une ligne vide comme la table
               DataRow ligne = dt.NewRow();

               // Etape 3 : remplir les colonnes
               ligne[0] = p.Reference;
               ligne[1] = p.Designation;
               ligne[2] = p.Quantite;
               ligne[3] = p.PrixAchat;

               // Etape 4 : ajouter la ligne dans la collection
               dt.Rows.Add(ligne);
           }*/
        
        public static DataTable AjouterProduit(Produit p)
        {
            // Etape 1 : choisir la table dans le DataSet
            //ili deja chargito fi charger
            DataTable dt = dsVente.Tables["TLProduit"];

            // Etape 2 : créer une ligne vide comme la table
            DataRow ligne = dt.NewRow();

            // Etape 3 : remplir les colonnes
            ligne[0] = p.Reference;
            ligne[1] = p.Designation;
            ligne[2] = p.Quantite;
            ligne[3] = p.PrixAchat;

            // Etape 4 : ajouter la ligne dans la collection
            dt.Rows.Add(ligne);
            return dt;
        }

        /*
        public static void EnregistrerProduit()
        {
            SqlConnection cnx = null;
            try
            {
                cnx = Connexionvente.GetInstance();
                // Etape 1 : vérifier SelectCommand
                da = new SqlDataAdapter("select * from tProduit", cnx);

                // Etape 2 : instancier CommandBuilder avec da en paramètre
                SqlCommandBuilder cmdBui = new SqlCommandBuilder(da);

                // Etape 3 : Update envoie les modifs vers SQL Server
                int n = da.Update(dsVente, "TLProduit");

                MessageBox.Show(n + " ligne(s) enregistrée(s) !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur enregistrement : " + ex.Message);
            }
        }*/
        public static bool EnregistrerProduit()
        {
            SqlConnection cnx = null;
            try
            {
                cnx = Connexionvente.GetInstance();
                // Etape 1 : vérifier SelectCommand
                da = new SqlDataAdapter("select * from tProduit", cnx);

                // Etape 2 : instancier CommandBuilder avec da en paramètre
                //ken fil enregister
                SqlCommandBuilder cmdBui = new SqlCommandBuilder(da);

                // Etape 3 : Update envoie les modifs vers SQL Server
                //nb de ligne
                int n = da.Update(dsVente, "TLProduit");

                if (n != 0)
                    return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur enregistrement : " + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
            return false;
        }
        public static DataTable SupprimerProduit(string reference)
        {
            DataTable dt = dsVente.Tables["TLProduit"];

            foreach (DataRow dr in dt.Rows)
            {
               // dr.Field<String>(0)
                
                if (dr[0].ToString().Equals(reference))
                {
                   dr.Delete(); 
                   break; 
                }
            }
            return dt;
        }
        //type de retour list ou datatable
        //bech nthabto biha l produit exist wala fil vue
        public static List<Produit> GetProduits()
        {
            List<Produit>lesProduits=new List<Produit>();
            DataTable dt = dsVente.Tables["TLProduit"];
            //5tr dataset deja m3obiya bech man3awdch n3abiha
            if (dt == null)
            {
                dt = ChargerProduits();
            }
            foreach (DataRow row in dt.Rows)
            {/*
                Produit p = new Produit(
                       dr.Field<String>(0),
                        dr.Field<String>(1),
                         dr.Field<int>(2),
                         dr.Field<float>(3)
                    );*/
                Produit p = new Produit(
                       row[0].ToString(),
                       row[1].ToString(),
                       Convert.ToInt32(row[2].ToString()),
                       float.Parse(row[3].ToString())
                   );
                lesProduits.Add(p);
            }
            return lesProduits;
        }
       
      
        public static DataTable ModifierProduit(Produit p)
        {
            DataTable dt = dsVente.Tables["TLProduit"];

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString().Equals(p.Reference))
                {
                    row[1] = p.Designation;
                    row[2] = p.Quantite;
                    row[3] = p.PrixAchat;
                    break;
                }
            }

            return dt;
        }
        public static Produit ChercherProduit(string reference)
        {
            DataTable dt = dsVente.Tables["TLProduit"];

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString().Equals(reference))
                {
                    Produit p = new Produit(
                      row[0].ToString(),
                      row[1].ToString(),
                      Convert.ToInt32(row[2].ToString()),
                      float.Parse(row[3].ToString())
                  );

                    return p;
                }
            }

            return null; 
        }
    }
}

