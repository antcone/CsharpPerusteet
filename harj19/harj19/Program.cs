using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj19
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Tämä on lämpötilamuunnin.");
            Console.WriteLine("Haluatko aloittaa?");
            Console.Write("y  n ");

            string choice;
            choice = Console.ReadLine();


            while (choice != "n")
            {

                Console.WriteLine();
                Console.WriteLine("Valitse muunnos.");
                Console.WriteLine("Celsius -> Fahrenheit     c ");
                Console.WriteLine("Fahrenheit -> Celsius     f ");
                string degree = Console.ReadLine();
                double celsius, fahrenheit, celsiusRounded; //tässä muuttujat, celsius, fahrenheit ja pyöristetty celsius

                if (degree == "c")  //tällä kertaa kelpaa vain pikku c
                {
                    Console.Write("Anna lämpötila Celsius-asteina: ");

                    celsius = double.Parse(Console.ReadLine());
                    fahrenheit = celsius * 9.0 / 5 + 32;  //ilmeisesti kaava tarvitsi desimaaliluvun, jotta vastauksetkin voisivat olla desimaaleina

                    // Console.WriteLine(celsius);
                    // Console.WriteLine(fahrenheit);

                    Console.Write($"Lämpötila Fahrenheit-asteina:  {fahrenheit}");



                }

                else if (degree == "f")

                {




                    //Console.WriteLine("Tämä on Fahrenheit-Celsius -muunnin.");  //esitellään, mitä koodi on tekevinään

                    Console.Write("Anna lämpötila Fahrenheit-asteina: ");  //kerrotaan, mitä käyttäjältä halutaan

                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;  // näköjään tässä kohtaa ylimääräiset sulut laskussa estivät koko kaavan toiminnan, ehkä. Mut tää vehje osas sanoa siitä 
                                                          // "Parentheses can be removed " 
                    celsiusRounded = Math.Round(celsius, 1);  //celsius pyöristetty yhden desimaalin tarkkuudelle. Ei pyydetty tekemään, mut kun huvitti
                                                              //siks vain pyöristetty celsius ku näytti et vain se tarvitsee pyöristämistä. Voin olla väärässäkin
                                                              //ilmeisesti tapoja pyöristää on useita, mut jospa tää olis tähän riittävän tarkka.
                    Console.Write($"Lämpötila Celsius-asteina:  {celsiusRounded}");  //kerrotaan pyöristetty lämpötila-arvo
                }




                else

                {

                    Console.WriteLine("Haluatko jatkaa?");
                    Console.WriteLine("y  n");
                    choice = Console.ReadLine();
                }

                // Console.WriteLine(celsius);
                // Console.WriteLine(fahrenheit);

                Console.WriteLine();

            }




            Console.ReadKey();
        }
    }
}
