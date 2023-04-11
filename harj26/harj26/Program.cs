using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj26
{
    class Program
    {
        static void Main(string[] args)
        { 
 

            int chosenNumber, i = 0; //alustetaan muuttuja
                                     // chosenNumber on käyttäjältä kysyttävä luku
                                     //i on laskuri


            Console.WriteLine("Tämä ohjelma tulostaa kokonaisluvut nollasta valitsemaasi lukuun asti."); //kerrotaan mitä ohjelma tekee
            Console.Write("Anna luku: ");
            chosenNumber = int.Parse(Console.ReadLine());  //kysytään luku
            Console.WriteLine();

            while (i <= chosenNumber)  //niin kauan kuin laskuri i on valittua lukua pienempi, tulostetaan lukuja


            {
             // Console.Write($"{i++}  ");   voishan ne näinkin esittää, mut en tiedä näyttääkö paremmalta
                Console.WriteLine(i++);            //näytetään luku ja kasvatetaan sitä yhdellä


            }


            Console.ReadKey();
        }
    }
}
