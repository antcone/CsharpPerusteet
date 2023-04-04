using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj28tunnilla
{
    class Program
    {
        static void Main(string[] args)
        {
            // 28 tunnilla. Josko ois hienompi ratkaisu tämä.
            // Ohjelma, joka kyysy mihin lukuun saakka tulostetaan lukuja
            // Käyttäjältä kysytään myös, tulostetaanko parilliset vai parittomat

            //1 pyydetään käyttäjältä luku
            //2 luetaan ja tallennetaan luku muuttujaan
            Console.Write("Syötä luku, johon asti tulostetaan: ");
            int number = int.Parse(Console.ReadLine());
           //3 luodaan silmukka, joka suoritetaan niin monta kertaa kuin 1-käyttäjäluku on
           //  -while, pitää miettiä jokin sopiva ehto
           //   - jotta voidaan tulostaa numeroita 1 alkaen, tarvitaan muuttuja, joka on alussa 1

            int i = 1; //iterointi i++ => i++ => i ==3 

            //kysytään käyttäjältä halutaanko parillinen vai pariton
            Console.Write("Parillinen / Pariton ");
            string input = Console.ReadLine();


            while (i <= number)

            {
                //Lisätään ehto, joka tulostaa vain parittoman numeron
                if (i%2 != 0 && input == "Pariton")
                {
                    Console.WriteLine(i);
                }

                else if ( i%2 == 0 && input == "Parillinen")
                {
                    Console.WriteLine(i);
                }

                //else
                //{
                //    Console.WriteLine($"urpo * {i}");
                //}

                i++; //suoritetaan iteraatio jokaisella silmukan kierroksella
            }

            Console.ReadKey();
           //4 silmukassa tulostetaan numero 1, jota iteroidaan joka kierros
        }
    }
}
