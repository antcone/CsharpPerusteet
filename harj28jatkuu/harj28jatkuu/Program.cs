using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj28jatkuu
{
    class Program
    {
        static void Main(string[] args)
        {
            //toistuva arvo ("Magic number") koodissa olis parempi korvata vakiolla, mut ei se const toiminukkaan tässä
            string EVEN_TEXT = "Parillinen";
            string ODD_TEXT = "Pariton";

            Console.Write("Syötä luku, johon asti tulostetaan: ");
            int number = int.Parse(Console.ReadLine());

            string input = ""; //muuttuja luodaan ennen silmukkaa, jotta sitä voi käyttää ehdossa
            bool inputFalse = true;

            while (inputFalse == true)  // while tarkistaa, että käyttäjä syöttää hyväksyttävän arvon
                                        //silmukka toistetaan niin kauan kuin käyttäjän input on väärin

            {
                Console.Write($"{EVEN_TEXT} / {ODD_TEXT}: ");
                input = Console.ReadLine();

                if (input == EVEN_TEXT)
                {
                    inputFalse = false;  //kun tämä muuttuja on false, silmukka pysähtyy
                }

                else if (input == ODD_TEXT)
                {
                    inputFalse = false;  //kun tämä muuttuja on false, silmukka pysähtyy
                }

            }

            //käyttäjän syöte tarkistetaan aiemmin
            int startingPoint = input == EVEN_TEXT ? 2 : 1;  //ternary


            //Parillinen alkaa 2
            //Pariton alkaa 1

            for (int i = startingPoint; i <= number; i += 2)  //iteraatio kahden välein
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();

            //foreach ei sovellu tähän tapaukseen, joten sillä ei yritetä

        }
    }
}
