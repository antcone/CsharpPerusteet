using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituskoe_pitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            Topping top1 = new Topping("Pepperoní");
            Topping top2 = new Topping("Herkkusieni");
            Topping top3 = new Topping("Oliivi");
            Topping top4 = new Topping("Jauheliha");
            Topping top5 = new Topping("Tonnikala");

            Console.WriteLine("Pitsan tilaus: ");

            Console.WriteLine("Valitut täytteet: ");
            Console.WriteLine();

            Console.WriteLine("Vaihtoehdot: ");
            Console.WriteLine($"1.{top1.Name} \n2.{top2.Name}\n3.{top3.Name}\n4.{top4.Name}\n5.{top5.Name}");

            Topping selectedTopping = null;
            bool userIsFinished = false;
            List<Topping> toppings = new List<Topping>();
            decimal basePrice = 15;

            while (!userIsFinished)
            {

                Console.WriteLine("Syötä täyte: (1-5) ");
                char inputChar = char.Parse(Console.ReadLine());

                switch (inputChar)
                {
                    case '1':
                        selectedTopping = top1;
                        toppings.Add(selectedTopping);
                        break;
                    case '2':
                        selectedTopping = top2;
                        toppings.Add(selectedTopping);
                        break;
                    case '3':
                        selectedTopping = top3;
                        toppings.Add(selectedTopping);
                        break;
                    case '4':
                        selectedTopping = top4;
                        toppings.Add(selectedTopping);
                        break;
                    case '5':
                        selectedTopping = top5;
                        toppings.Add(selectedTopping);
                        break;
                    case 'e':
                        userIsFinished = true;
                        break;
                }




            }


            Pizza selectedPizza = new Pizza(toppings, basePrice);
            Console.WriteLine("Valitsit seuraavat täytteet: ");


            foreach (Topping topping in selectedPizza.Toppings)
            {
                Console.WriteLine(topping.Name);
            }

            Console.WriteLine($"Pitsan hinta on {selectedPizza.CalculatePrice()}");


            Console.ReadKey();

        }
    }
}
