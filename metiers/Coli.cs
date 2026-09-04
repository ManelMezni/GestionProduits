using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metiers
{
    public class Coli
    {
      
        String numero;
        DateTime dateLiv;
        int qtecol;
        Produit produit;

        public Coli(string numero, DateTime dateLiv, int qtecol, Produit produit)
        {
            this.numero = numero;
            this.dateLiv = dateLiv;
            this.qtecol = qtecol;
            this.produit = produit;
        }

        public string Numero { get => numero; set => numero = value; }
        public DateTime DateLiv { get => dateLiv; set => dateLiv = value; }
        public int Qtecol { get => qtecol; set => qtecol = value; }
        public Produit Produit { get => produit; set => produit = value; }

        public override bool Equals(object obj)
        {
            return obj is Coli coli &&
                   numero == coli.numero;
        }
    }
}
