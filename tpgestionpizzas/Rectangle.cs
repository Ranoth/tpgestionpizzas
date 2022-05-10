using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpgestionpizzas
{
    class Rectangle : Forme
    {
        double hauteur;
        double largeur;

        public Rectangle(string libelle, double hauteur, double largeur):base(libelle)
        {
            this.hauteur = hauteur;
            this.largeur = largeur;
        }

        public double Hauteur { get => hauteur; set => hauteur = value; }
        public double Largeur { get => largeur; set => largeur = value; }

        public override double GetSurface()
        {
            return Hauteur * Largeur;
        }
        public override string ToString()
        {
            return Libelle + " (Hauteur: " + Hauteur + ", Largeur: " + Largeur + ")";
        }
    }
}
