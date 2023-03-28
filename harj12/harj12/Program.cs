using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ageCorrect = false;

            while (!ageCorrect)
            {
                Console.Write("Syötä ikä: ");
                int age = int.Parse(Console.ReadLine());
                int minAge = 0;  //minimi-ikä
                int maxAge = 120; //maksimi-ikä

                //tarkistetaan, että ikä on sopiva

                if (age >= minAge && age <= maxAge)

                {
                    ageCorrect = true;
                    Console.WriteLine("Tallennus onnistui :)");
                }
                else
                {
                    Console.WriteLine("Arvo ei ole hyväksyttävällä välillä " +
                        $"({minAge} - {maxAge})");
                }

            } // ctrl + a, ctrl + k, ctrl + d  sisentää kuulemma koodin hauskasti
            // alt pohjassa ja nuolilla voi liikuksia jännästi
            Console.ReadKey();

        }
    }
}
