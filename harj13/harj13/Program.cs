using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna hinta: ");

            double price = double.Parse(Console.ReadLine());
            double salePrice;

            if (price > 100)  // jos hinta yli 100 egee
            {
                salePrice = price * 0.75; //alennus 25 %
            }
            else
            {
                salePrice = price * 0.90; //muulloin ale 10%, eli alkup. hinta *0.9
            }

            //Console.WriteLine("Alehintasi on " + salePrice + " euroa");  // mitä jos vain kirjoittais aina tälleen eikä
            Console.WriteLine($"Alehintasi on {salePrice} euroa");

            Console.ReadKey();

        }
    }
}
