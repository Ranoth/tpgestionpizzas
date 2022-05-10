using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpgestionpizzas
{
    class CommandeComptoir : Commande
    {
        int numTable;
        public CommandeComptoir(int numTable)
        {
            this.numTable = numTable;
        }
        public int NumTable { get => numTable; set => numTable = value; }

        public override void AfficheDetail()
        {
            Console.WriteLine("Table n°: " + NumTable);
            Console.WriteLine("Détails de la commande: ");
            Console.WriteLine("Commande n° " + Numero);
            foreach (Pizza p in LesPizzas)
            {
                p.AfficheDetail();
            }
            Console.WriteLine("---------------------------------------------\nPrix total : " + TotalCommande());
        }
        public override decimal TotalCommande()
        {
            decimal tot = 0;
            foreach (Pizza p in LesPizzas)
            {
                tot += p.GetPrix();
            }
            return tot;
        }
    }
}
