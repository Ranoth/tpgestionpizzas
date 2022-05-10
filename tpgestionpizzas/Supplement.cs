using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpgestionpizzas
{
    class Supplement : Ingredient
    {
        double prix;

        public Supplement(string nom, int qte, double prix):base(nom, qte)
        {
            this.prix = prix;
        }

        public double Prix { get => prix; set => prix = value; }

        public override string ToString()
        {
            return "----- Supplément: " + Nom + "(Quantité: " + Qte + ") Prix: " + Prix;
        }
    }
}
