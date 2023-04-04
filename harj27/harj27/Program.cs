using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj27
{
    class Program
    {
        static void Main(string[] args)
        {
            //27. Toisto: Merkkien tulostus

            //1. Pyydetään käyttäjältä numero ja tallennetaan se muuttujaan
            Console.WriteLine("Tämä ohjelma tulostaa haluamasi määrän valitsemaasi merkkiä.");
            Console.Write("Syötä numero: ");
            int number = int.Parse(Console.ReadLine());

            //2. Lisätään silmukka, joka suoritetaan käyttäjän syöttämän numeron verran
            //Tulostetaan yksi merkki, toistetaan käyttäjän syöttämän numeron verran
            // while / do while
            // for    < tää o hyvä
            // foreach

            Console.Write("Syötä merkki: ");
            char symbol = char.Parse(Console.ReadLine());
            
            for (int i = 0; i < number; i++)  //jos number = 5 ja i = 0: 0, 1,2,3,4 => suoritetaan 5 kertaa
            // for (int = 1;; i<= number; i++)  voi olla näinkin, huom ero
            {
                Console.Write(symbol);  //

            }




            Console.ReadKey();

        }
    }
}
