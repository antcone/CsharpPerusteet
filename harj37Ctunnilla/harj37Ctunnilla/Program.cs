using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj37Ctunnilla
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] measurementTimes = { "6:00", "12:00", "18:00", "24.00" };
            // DateTime[] test = { DateTime.Now, DateTime.Now };  jotain hipleetä

            double[] temperaturesArray = new double[measurementTimes.Length]; //taulukko
            List<double> temperaturesList = new List<double>();  //lista

            // 2. Lue silmukka, jossa käyttäjän arvot luetaan ja tallennetaan taulukkoon ja listaan


            //List.Count == 0, joten se ei kelpaa ehdoksi
            for (int i = 0; i < measurementTimes.Length; i++)

            {
                Console.Write($"Syötä kello {measurementTimes[i]} lämpötila: ");
                double input = double.Parse(Console.ReadLine());
                temperaturesArray[i] = input;  // Taulukko
                temperaturesList.Add(input);  // Lista
            }

            Console.WriteLine($"Taulukon suurin lämpötila on {temperaturesArray.Max()}");
            Console.WriteLine($"Taulukon pienin lämpötila on {temperaturesArray.Min()}");
            Console.WriteLine($"Taulukon keskiarvolämpötila on {temperaturesArray.Average()}");

            Console.WriteLine($"Listan suurin lämpötila on {temperaturesList.Max()}");
            Console.WriteLine($"Listan pienin lämpötila on {temperaturesList.Min()}");
            Console.WriteLine($"Listan keskiarvolämpötila on {temperaturesList.Average()}");


            //Algoritmi, termi koodille, joka suorittaa jonkin asian
            //Tässä algoritmi, joka laskee keskiarvon
            //katsoimme mallia c#-lähdekoodista, joka on githubissa
            //ja vielä helpommin selattavissa osoitteessa referencesource.microsoft.com

            int count = 0;
            double sum = 0;

            foreach (double temp in temperaturesArray)
            {
                sum += temp;
                count++;
            }

            Console.WriteLine($"Taulukon keskiarvo on {sum / count}");

            // Tässä algoritmi, joka hakee listasta suurimman arvon.

            double value = 0; //Tästä arvosta lähdetään liikkeelle ja tallennetaan suurin arvo.

            for (int i = 0; i < temperaturesList.Count; i++)
            {
                //Korvataan oletusarvo 0 ensimmäisellä kierroksella 
                //tää oli, jotta ei tulis jotai bugia
                if (i == 0)
                {
                    value = temperaturesList[i];
                }

                //Onko uusi arvo suurempi kuin vanha arvo

                if (temperaturesList[i] > value)
                {
                    value = temperaturesList[i]; //otetaan talteen isompi arvo

                }

            }

            Console.WriteLine($"Listan suurin arvo on {value} ");


            value = 0;

            for (int i = 0; i < temperaturesList.Count; i++)
            {
                //Korvataan oletusarvo 0 ensimmäisellä kierroksella 
                //tää oli, jotta ei tulis jotai bugia
                if (i == 0)
                {
                    value = temperaturesList[i];
                }

                //Onko uusi arvo pienempi kuin vanha arvo

                if (temperaturesList[i] < value)
                {
                    value = temperaturesList[i]; //otetaan talteen pienempi arvo

                }

            }


            Console.WriteLine($"Listan pienin arvo on {value} ");




            Console.ReadKey();

        }
    }
}
