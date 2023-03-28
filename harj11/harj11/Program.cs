using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            // C# Valinta : luvun vertailutehtävä

            Console.Write("Anna luku ");   //pyydetään käyttäjältä luku
            int value = int.Parse(Console.ReadLine());
           
            if (value == 0)

            {
                Console.WriteLine("Antamasi luku on 0");
            }

            else if (value < 0)

            {
                Console.WriteLine("Antamasi luku " + value + " on pienempi kuin 0");  // no muutenvaan tällanen mukahienompi rivi
            }
            else
                Console.WriteLine("Antamasi luku on isompi kuin 0");

            Console.ReadKey();
        }
    }
}
