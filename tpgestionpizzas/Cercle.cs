using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpgestionpizzas
{
    class Cercle : Forme
    {
        double diametre;

        public Cercle(string libelle, double diametre):base(libelle)
        {
            this.diametre = diametre;
        }

        public double Diametre { get => diametre; set => diametre = value; }

        public override double GetSurface()
        {
            return Diametre * 3.14;
        }
        public override string ToString()
        {
            return Libelle + " (Diametre: " + Diametre + ")";
        }
    }
}
