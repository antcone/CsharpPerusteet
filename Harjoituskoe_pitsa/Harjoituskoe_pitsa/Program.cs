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
            Topping top1 = new Topping("Pepperoni");
            Topping top2 = new Topping("Herkkusieni");
            Topping top3 = new Topping("Oliivi");
            Topping top4 = new Topping("Jauheliha");
            Topping top5 = new Topping("Tonnikala");

            //  Console.WriteLine("Vaihtoehdot: ");
            //  Console.WriteLine($"1.{top1.Name} \n2.{top2.Name}\n3.{top3.Name}\n4.{top4.Name}\n5.{top5.Name}");
            List<Topping> allToppings = new List<Topping>();
            allToppings.Add(top1);
            allToppings.Add(top2);
            allToppings.Add(top3);
            allToppings.Add(top4);
            allToppings.Add(top5);                //  no siis ei tartte tehdä näi ku olis riittäny vaa
           // allToppings.Add("Oliivi");               mut en jaksa nyt muuttaa               */

            Topping selectedTopping = null;
            bool userIsDoneOrdering = false;
            List<Topping> toppings = new List<Topping>();
            decimal basePrice = 15;

            Pizza userPizza = new Pizza();

            while (userIsDoneOrdering == false)
            {
                Console.Clear();

                Console.WriteLine("Pitsan tilaus: ");
                Console.WriteLine();

                Console.WriteLine("Valitut täytteet:");
                for(int i = 0; i <userPizza.Toppings.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {userPizza.Toppings[i].Name}");
                }
                Console.WriteLine();

                
                Console.WriteLine("Vaihtoehdot: ");

                for (int i = 0; i < allToppings.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {allToppings[i].Name}");
                }

               // Console.WriteLine($"1.{top1.Name} \n2.{top2.Name}\n3.{top3.Name}\n4.{top4.Name}\n5.{top5.Name}");
                Console.WriteLine();
                Console.Write($"Syötä täyte (1-{allToppings.Count}) tai e: ");
                string input = Console.ReadLine();

                if (input == "e")
                {
                    userIsDoneOrdering = true;
                }
                else
                {
                    int indexOfTopping = int.Parse(input) - 1;

                    Topping tempTopping = allToppings[indexOfTopping];  //<== viittaus täyte-objektiin

                    userPizza.Toppings.Add(tempTopping);
                    
                }



                // kuulemma switch ei oo skaalautuva, siks me ei oikeestaan haluta sitä
              /*  switch (inputChar)  //no en tiedä taas miks tein alunperin charin, ei se oo koskaan näppärä tähän
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
                        userIsDoneOrdering = true;
                        break;
                    default:
                        //jokin virheilmoitus
                        break;
                        
                } */

            }

            Console.Clear();
            Pizza selectedPizza = new Pizza(toppings, basePrice);
            Console.WriteLine($"Valitsit seuraavat {toppings.Count} täytettä: ");

            /*
                        foreach (Topping topping in selectedPizza.Toppings)
                        {
                            Console.WriteLine(topping.Name);
                        }  */

            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {toppings[i].Name}");
            }


            decimal price = userPizza.CalculatePrice();
            Console.WriteLine();
            Console.WriteLine($"Pitsan hinta on {selectedPizza.CalculatePrice()} euroa.");
            Console.WriteLine($"Pitsan hinta on {price} euroa.");

            Console.Write("Hyväksy tilaus (k/e): ");
            char submitOrder = char.Parse(Console.ReadLine());
            Console.Clear();

            if(submitOrder == 'k' || submitOrder == 'K')
            {
                Console.WriteLine("Tilaus hyväksytty.");
                Console.Write("Anna osoitteesi: ");
                string userAddress = Console.ReadLine();
                Console.Clear();
                
                Console.WriteLine($"Pitsa toimitetaan osoitteeseen {userAddress}");
                Console.WriteLine("Kiitos tilauksesta!");
            }
            else
            {
                Console.WriteLine("Tilaus peruttu.");
            }
            
           

            Console.ReadKey();

        }
    }
}
