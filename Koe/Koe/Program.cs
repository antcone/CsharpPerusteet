using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Syötä puhelinnumero (+358XXXXXXXXX): ");
            string userInput = Console.ReadLine();

            string countryCode = "+358";
            int expectedLength = 13;

            //maakoodin ehto
            bool isCountryCodeRight = userInput.Substring(0, Math.Min(userInput.Length, countryCode.Length)) == countryCode;  //tähän lisäsin vasta myöhemmin tuon Math.Min-hauskuuden, joka
                                                                                                                              // on tuttu tuolta myöhempää. Koska tää kaatu, jos userInput.Length
                                                                                                                              // oli pienempi kuin countrycode.Length
            bool containsOnlyDigits = true;


            if (userInput.Length != expectedLength)
            {
                Console.WriteLine("Numeron tulee olla 13 merkkiä pitkä.");
            }


            if (!isCountryCodeRight)
            {
                Console.WriteLine("Puhelinnumeron tulee alkaa \"+358\".");
            }


            for (int i = 4; i < userInput.Length; i++)  //löyty tällanen metodi, jolla voidaan tarkastaa, onko merkki digit (0-9) vai ei. 
                                                        //Aloitetaan huvikseen vertailu vasta  maakoodin jälkeen, koska se tarkistettiin yllä.

            {
                if (!Char.IsDigit(userInput, i))
                {
                    containsOnlyDigits = false;
                }
            }

            if (!containsOnlyDigits)
            {
                Console.WriteLine("Puhelinnumerossa on kiellettyjä merkkejä.");
            }


            Console.ReadKey();
            Console.Clear();
            Console.Write("Syötä etunimi: ");
            string inputFirstName = Console.ReadLine();

            Console.Write("Syötä sukunimi: ");
            string inputLastName = Console.ReadLine();

            string userName = userNameGenerator(inputFirstName, inputLastName);

            Console.WriteLine();
            Console.WriteLine($"Käyttäjätunnus on {userName}");
            Console.ReadKey();



            Console.Clear();
            List<JavelinThrow> throws = new List<JavelinThrow>();

            bool userNotFinished = true;
            int idCounter = 0;


            while (userNotFinished)
            {

                Console.Write("Syötä heittäjän nimi: ");
                string inputName = Console.ReadLine();


                Console.Write("Syötä heiton metrit: ");
                int inputMeters = int.Parse(Console.ReadLine());

                Console.Write("Syötä heiton senttimetrit: ");
                int inputCentimeters = int.Parse(Console.ReadLine());

                idCounter++;

                Console.WriteLine();
                Console.Write("Haluatko lopettaa? k/e ");
                string end = Console.ReadLine();

                if (end == "k")
                {
                    userNotFinished = false;
                }

                JavelinThrow temp = new JavelinThrow(idCounter, inputName, inputMeters, inputCentimeters);
                throws.Add(temp);

            }

            Console.Clear();
            Console.WriteLine("Heittäjien tiedot:");
            Console.WriteLine();
            Console.WriteLine("Id\t\tHeittäjän nimi\t\tMetrit\t\t\tSenttimetrit");

            foreach (JavelinThrow t in throws)
            {
                Console.WriteLine($" {t.Id}\t\t{t.AthleteName}\t\t\t{t.Meters}\t\t\t{t.Centimeters}");
            }

            Console.ReadKey();


            Console.Clear();
            List<Product> products = new List<Product>();

            bool userWantsToContinue = true;

            while (userWantsToContinue)
            {

                Console.Clear();
                Console.Write("Syötä tuotteen id: ");
                int inputId = int.Parse(Console.ReadLine());

                Console.Write("Syötä tuotteen nimi: ");
                string inputProductName = Console.ReadLine();

                Console.Write("Syötä tuotteen hinta (e): ");
                decimal inputPrice = decimal.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Syötä uusi tuote? (k/e): ");
                string addMore = Console.ReadLine();
                if (addMore != "k")
                {
                    userWantsToContinue = false;
                }

                Product inputProduct = new Product(inputId, inputProductName, inputPrice);
                products.Add(inputProduct);

            }

            Console.Clear();
            Console.WriteLine("Tuotetiedot:");
            Console.WriteLine();
            Console.WriteLine($"Tuoteid\t\t\tTuotenimi\t\tNormaali hinta (e)\t\tAlennettu hinta (e)");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($" {products[i].Id}\t\t\t{products[i].Name}\t\t\t{products[i].Price}\t\t\t\t{products[i].CalculateDiscountedPrice(20)}");
            }


            Console.ReadKey();

        }

        private static string userNameGenerator(string firstName, string lastName)
        {
            //Substring-metodi vertailee stringejä, Math.Min-metodin avulla hoidetaan mahdolliset kolmea ja viittä merkkiä lyhyemmät nimet
            string shortenedFirstName = firstName.Substring(0, Math.Min(firstName.Length, 3));
            string shortenedLastName = lastName.Substring(0, Math.Min(lastName.Length, 5));
            string userName = shortenedLastName + shortenedFirstName;

            return userName;
        }



    }





}
