using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpgestionpizzas
{
    abstract class Commande : ICommande
    {
        private static int NbrCmd = 0;

        List<Pizza> lesPizzas = new List<Pizza>();
        int numero;
        public Commande()
        {
            NbrCmd++;
            numero = NbrCmd;
        }
        internal List<Pizza> LesPizzas { get => lesPizzas; set => lesPizzas = value; }
        public int Numero { get => numero; set => numero = value; }

        public abstract void AfficheDetail();
        public void AjouterPizza(Pizza p)
        {
            LesPizzas.Add(p);
        }
        public abstract decimal TotalCommande();
    }
}
