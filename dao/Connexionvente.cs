using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;///! b3d asssembly kifkif ifref dao
namespace dao
{
    public class Connexionvente
    {
       static string url = @"Server=DESKTOP-5DK0TQB\SQLEXPRESS;Database=BDCommerciale;Trusted_Connection=True";

       static SqlConnection cnx = new SqlConnection(url);
        public static SqlConnection GetInstance()
        {
            try
            {
                // ou cnx.State != System.Data.ConnectionState.open
                if (cnx !=null && cnx.State == System.Data.ConnectionState.Closed)
                    cnx.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Vente: Pb de connexion\n " + ex.Message); 
            }
            return cnx;
        }
       
    }
}
