using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpgestionpizzas
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingrédients
            Ingredient i1 = new Ingredient("pate", 1);
            Ingredient i2 = new Ingredient("jambon", 2);
            Ingredient i3 = new Ingredient("tomate", 3);
            Ingredient i4 = new Ingredient("capres", 4);
            Ingredient i5 = new Ingredient("Mozzarella", 6);
            Ingredient i6 = new Ingredient("fromage", 2);
            Ingredient i7 = new Ingredient("saumon", 1);
            Ingredient i8 = new Ingredient("lardons", 5);


            //suppléments
            Supplement s1 = new Supplement("Mozarella", 2, 1.2);
            Supplement s2 = new Supplement("lardon", 4, 0.7);
            Supplement s3 = new Supplement("caprs", 2, 0.5);

            //formes
            Cercle c1 = new Cercle("petite ronde", 20);
            Cercle c2 = new Cercle("grande ronde", 40);
            Rectangle r1 = new Rectangle("petite rectangulaire", 20, 20);
            Rectangle r2 = new Rectangle("grande rectangulaire", 40, 40);

            //pizza
            Pizza p1 = new Pizza("Royale", c1, Convert.ToDecimal(9.5));
            try
            {
                p1.AddIngredient(i1);
                p1.AddIngredient(i2);
                p1.AddIngredient(i3);
                p1.AddIngredient(s1);
                p1.AddIngredient(s2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Pizza p2 = new Pizza("Norvegienne", c1, Convert.ToDecimal(9.5));
            p2.AddIngredient(i1);
            p2.AddIngredient(i7);
            p2.AddIngredient(s1);
            p2.AddIngredient(s3);

            //IPizza p2 = (IPizza)p1;
            //p2.AfficheDetail();
            //decimal prix = p2.GetPrix();
            //Console.WriteLine("Le prix de la pizza est de : " + prix + " euros");
            //Console.WriteLine("\nLa surface de cette pizza est de " + p2.GetSurface() + " cm²");

            // création d'une commande comptoir
            Console.WriteLine("*************************************************************");
            CommandeComptoir com1 = new CommandeComptoir(2);
            com1.AjouterPizza(p1);
            com1.AjouterPizza(p2);
            ICommande Icom1 = (ICommande)com1;
            Icom1.AfficheDetail();
            Console.WriteLine("*************************************************************");
            Console.WriteLine("*************************************************************");
            // création d'une commande téléphone
            CommandeTelephone com2 = new CommandeTelephone(12, "01.25.36.45.58");
            com2.AjouterPizza(p1);
            ICommande Icom2 = (ICommande)com2;
            Icom2.AfficheDetail();
            Console.WriteLine("**************************************************************");

            GestionCommande gc1 = new GestionCommande();
            gc1.AddCommande(com1);
            gc1.AddCommande(com2);
            gc1.AfficheCA();
        }
    }
}

