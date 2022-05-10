using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpgestionpizzas
{
    abstract class Forme
    {
        string libelle;

        public Forme()
        {

        }
        protected Forme(string libelle)
        {
            this.libelle = libelle;
        }

        public string Libelle { get => libelle; set => libelle = value; }

        public abstract double GetSurface();
        public override string ToString()
        {
            return Libelle;
        }
    }
}
