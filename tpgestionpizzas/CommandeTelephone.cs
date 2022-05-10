using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpgestionpizzas
{
    class CommandeTelephone : Commande
    {
        int distance;
        string tel;

        public CommandeTelephone(int distance, string tel)
        {
            this.distance = distance;
            this.tel = tel;
        }

        public int Distance { get => distance; set => distance = value; }
        public string Tel { get => tel; set => tel = value; }

        public override void AfficheDetail()
        {
            Console.WriteLine("----------Informations Client----------");
            Console.WriteLine("Téléphone : " + Tel);
            Console.WriteLine("Distance : " + Distance);
            Console.WriteLine("Port : " + (Distance*0.5));
            Console.WriteLine("Commande n° " + Numero);
            foreach (Pizza p in LesPizzas)
            {
                p.AfficheDetail();
            }
            Console.WriteLine("Prix total : " + TotalCommande());
        }
        public override decimal TotalCommande()
        {
            decimal tot = 0;
            foreach (Pizza p in LesPizzas)
            {
                tot += p.GetPrix() + Convert.ToDecimal(Distance*0.5);
            }
            return tot;
        }
    }
}
