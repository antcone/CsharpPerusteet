using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj14switch
{
    class Program
    {
        static void Main(string[] args)
        {       //switch
            //// pyydetään käyttäjää antamaan luku
            //Console.Write("Anna luku: ");

            ////luetaan luku ja tallennetaan muuttujaan
            //int userNumber = int.Parse(Console.ReadLine());

            //switch (userNumber % 2)  //suoritetaan jakojäännöksen laskeminen
            //{
            //    case 0:  // Verrataan jakojäännöksen tulosta. Jakojäännös on 0, eli parillinen
            //        Console.WriteLine($"Numero  {userNumber} on parillinen");
            //        break;
            //   // case 1:  //jakojäännökseen jäi 1, eli luku on pariton
            //    default: //voi käyttää myös defaulttia, koska luku on parillinen, jollei ollut parillinen
                    
            //        Console.WriteLine($"Numero {userNumber} on pariton");
            //        break;
            //}


            //ternary
            // pyydetään käyttäjää antamaan luku
            Console.Write("Anna luku: ");

            //luetaan luku ja tallennetaan muuttujaan
            int userNumber = int.Parse(Console.ReadLine());

            //                  ehto                            arvo jos true             :             arvo jos false
            string message = (userNumber % 2 == 0) ? $"Numero {userNumber} on parillinen" : $"Numero {userNumber} on pariton";
            //   Tässä kohtaa voi ketjuttaa uuden ternary operaation


            Console.WriteLine(message); //näytetään tulos käyttäjälle



            Console.ReadKey();

        }
    }
}
