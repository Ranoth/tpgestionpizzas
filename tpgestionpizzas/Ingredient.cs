using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpgestionpizzas
{
    class Ingredient
    {
        string nom;
        int qte;

        public Ingredient(string nom, int qte)
        {
            this.nom = nom;
            this.qte = qte;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Qte { get => qte; set => qte = value; }

        public override string ToString()
        {
            return Nom + "(Quantité: " + Qte + ")";
        }
    }
}