using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using metiers;
using dao;
namespace Controller
{
    public class ProduitController
    {
        public static List<Produit> GetProduit()
        {
            List<Produit> produits = ProduitDAO.FindAll();

            return produits;
        }
        public bool Add(Produit p)
        {

            List<Produit> produits = ProduitController.GetProduit();
            if (produits.Contains(p))
                return false;

            ProduitDAO.Add(p);

            return true;
        }

    }
}
