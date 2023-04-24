using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bensankulutus24._4lähi
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Funktiot: Bensankulutus
            //https://moodle.sakky.fi/mod/assign/view.php?id=1159675
            //päätettiin käyttää decimalia, koska onhan tässä rahaa, ja decimal on edelleen tarkin datatyyppi desimaaliluvuille

            //Kohta 5, lisätään koko koodi silmukkaan
            bool userEndsLoop = false;

            // List<(decimal, decimal, decimal)> test = new List<(decimal, decimal, decimal)>();  //Tuple
            //Tehhäänki listat kaikille muuttujille löl (ite tein vain sille lopputulokselle)
            List<decimal> userDistances = new List<decimal>();
            List<decimal> userAverageConsumption = new List<decimal>();
            List<decimal> userFuelPrice = new List<decimal>();
            // Kun käytetään useaa eri listaa tai taulua, täytyy hallita indeksien käyttö oikein eri listojen välillä

            (decimal, decimal, decimal)[] trips = new (decimal, decimal, decimal)[1];



            while (userEndsLoop == false)
            {

                Console.Write("Syötä ajettu matka (km): ");
                decimal distance = decimal.Parse(Console.ReadLine());
                userDistances.Add(distance);

                Console.Write("Syötä ajoneuvon keskikulutus (l/100km): ");
                decimal averageConsumption = decimal.Parse(Console.ReadLine());
                userAverageConsumption.Add(averageConsumption);

                Console.Write("Syötä polttoaineen hinta (€/l): ");
                decimal FuelPrice = decimal.Parse(Console.ReadLine());
                userFuelPrice.Add(FuelPrice);


                //viimeinen indeksi saadaan tälleen jännästi näköjään
                trips[trips.Length - 1] = (distance, averageConsumption, FuelPrice);

                // decimal tripCost = carTripCostCalculator(distance, averageConsumption, fuelPrice);

                // Console.WriteLine();
                // Console.WriteLine($"Ajetun matkan hinta on {tripCost} euroa.");
                // Console.WriteLine();

                Console.WriteLine("Calculate another trip? (y/n)");
                string input = Console.ReadLine();

                if (input == "n")  //käyttäjä lopettaa sovelluksen
                {
                    userEndsLoop = true;  //kun tämä muuttuja on true, silmukka päättyy
                }
                else //laajennetaan taulukko
                {
                    trips = expandArray(trips);  // expandArray palauttaa uuden taulukon, joka on yhtä suurempi kuin
                                                 // alkuperäinen taulukko, joka annetaan parametrinä
                }

            }

            // Käydään listat läpi ja tulostetaan matkojen hinnat

            for (int i = 0; i < userDistances.Count; i++)
            {
                Console.WriteLine($"Matkan {i + 1} hinta on {carTripCostCalculator(userDistances[i], userAverageConsumption[i], userFuelPrice[i])} euroa");
            }





            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }


        //parametrien yksiköt joko kommentoidaan tai lisätään parametrien nimiin
        private static decimal carTripCostCalculator(decimal distanceInKilometres, decimal averageConsumption, decimal fuelCost)
        {
            decimal result = 0;

            result = distanceInKilometres * averageConsumption * fuelCost / 100;

            return result;
        }


        private static (decimal, decimal, decimal)[] expandArray((decimal, decimal, decimal)[] originalArray)
        {
            // Luodaan uusi taulukko, joka on yhtä indeksiä suurempi kuin alkuperäinen taulukko
            (decimal, decimal, decimal)[] newArray = new (decimal, decimal, decimal)[originalArray.Length + 1];

            // tämä olis kuulemma parempi olla omana metodinaan. Jokainen oma toiminnallisuus kuuluu omaan metodiin.
            // mut emme välitä siitä tänään
            // Kopioidaan arvot vanhasta taulukosta uuteen taulukkoon
            for (int i = 0; i < originalArray.Length; i++)
            {
                newArray[i] = originalArray[i];
            }

            return newArray;
        }




    }
}
