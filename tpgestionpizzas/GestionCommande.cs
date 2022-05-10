using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpgestionpizzas
{
    class GestionCommande
    {
        List<Commande> LesCommandes = new List<Commande>();

        public void AddCommande(Commande c)
        {
            LesCommandes.Add(c);
        }

        public void AfficheCA()
        {
            decimal ca = 0;
            foreach (Commande c in LesCommandes)
            {
                ca += c.TotalCommande();
            }
            Console.WriteLine("\n==========================> Chiffre d'affaire : " + ca + " euros");
        }
    }
}
