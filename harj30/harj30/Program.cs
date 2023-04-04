using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj30
{
    class Program
    {
        static void Main(string[] args)
        {
            // 30 Kertymä
            //for -versio

            //Console.WriteLine("Tämä nerokas ohjelma kertoo kertymän.");
            //Console.Write("Anna kierroslukumäärä: ");

            //int number = int.Parse(Console.ReadLine());  //käyttäjältä kysyttävä kierrosten määrä
            //int sum = 0;                                // esitellään ja alustetaan summamuuttuja


            //for (int i = 0; i < number; i++)
            //{
            //     sum += i;    //lisätään summaan i joka kierroksella
            //                 //sum = sum + i;

            //}

            //Console.WriteLine($"{number} kierrosta, kertymäksi saatiin: {sum}");


            //Console.ReadKey();

            
            
            //while -versio *harjoituksen vuoksi*

            Console.WriteLine("Tämä nerokas ohjelma kertoo kertymän.");
            Console.Write("Anna kierroslukumäärä: ");

            int number = int.Parse(Console.ReadLine());  //käyttäjältä kysyttävä kierrosten määrä
            int sum = 0; // esitellään ja alustetaan summamuuttuja
            int i = 0;  //laskuri

            while (i < number)
            {
                sum += i;    //lisätään summaan i joka kierroksella
                             //sum = sum + i;
                i++;        //kasvatetaan laskuria
            }

            Console.WriteLine($"{number} kierrosta, kertymäksi saatiin: {sum}");


            Console.ReadKey();














        }
    }
}
