using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpgestionpizzas
{
    class Pizza : IPizza
    {
        private List<Ingredient> LesIngredients = new List<Ingredient>();
        Forme maForme;
        string nom;
        decimal prixBase;

        public Pizza(string nom, Forme maForme, decimal prixBase)
        {
            this.maForme = maForme;
            this.nom = nom;
            this.prixBase = prixBase;
        }
        public Pizza(string nom, Forme maForme, decimal prixBase, List<Ingredient> lesIngredients)
        {
            LesIngredients = lesIngredients;
            this.maForme = maForme;
            this.nom = nom;
            this.prixBase = prixBase;
        }

        public string Nom { get => nom; set => nom = value; }
        public decimal PrixBase { get => prixBase; set => prixBase = value; }
        internal List<Ingredient> lesIngredients { get => LesIngredients; set => LesIngredients = value; }
        internal Forme MaForme { get => maForme; set => maForme = value; }

        public void AddIngredient(Ingredient i)
        {
            bool isNullOrEmpty = LesIngredients?.Any() != true;
            if (isNullOrEmpty || !LesIngredients.Contains(i))
            {
                LesIngredients.Add(i);
            }
            else if ((!isNullOrEmpty || LesIngredients.Contains(i)) && (i.GetType().Name == "Ingredient"))
            {
                throw new Exception("Vous avez déjà ajouté cet ingrédient");
            }
            else if ((!isNullOrEmpty || LesIngredients.Contains(i)) && (i.GetType().Name == "Supplement"))
            {
                throw new Exception("Vous avez déjà ajouté ce supplément");
            }
        }

        public void AfficheDetail()
        {
            Console.WriteLine("---------------Composition---------------");
            string str = "Pizza " + Nom + "    Prix: " + PrixBase + "    " + MaForme;

            foreach (Ingredient i in LesIngredients)
            {
                str += "\n" + i.ToString();
            }
            Console.WriteLine(str);
            Console.WriteLine("Prix total de la pizza : " + GetPrix() + " euros");
        }

        public decimal GetPrix()
        {
            decimal prixTot = PrixBase;
            foreach (Ingredient i in LesIngredients)
            {
                if (i is Supplement)
                {
                    Supplement s = (Supplement)i;
                    prixTot += Convert.ToDecimal(s.Prix*s.Qte);
                }
            }
            return prixTot;
        }
        public double GetSurface()
        {
            return MaForme.GetSurface();
        }
    }
}
