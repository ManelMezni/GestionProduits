using dao;
using metiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ColiController
    {
        static List<Coli>lescolis;
        static List<Produit> lesproduits; 
        
        public static List<Coli> GetColis()
        {
            if (lescolis == null)
               lescolis= ColiDAO.FindAll();
            return lescolis;
        }

        public static bool AjouterColis(Coli c)
        {
            if (c.Qtecol < c.Produit.Quantite)
            {
                ColiDAO.Add(c);
                c.Produit.Quantite -= c.Qtecol;
                ProduitDAO.Update(c.Produit);
                lescolis=ColiDAO.FindAll();
                lesproduits=ProduitDAO.FindAll();   
                return true;    
            }

            return true;
        }


    }
}
