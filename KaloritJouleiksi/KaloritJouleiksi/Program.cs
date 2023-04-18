using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloritJouleiksi
{
    class Program
    {
        static void Main(string[] args)
        {

            //            C# Funktiot: Kalorit jouleiksi
            //            Kirjoita ohjelma, joka muuttaa kalorit jouleiksi ja päinvastoin. Joulet voidaan muuntaa kaloreiksi kertomalla ne luvulla 0,2390 
            //            ja kalorit jouleiksi kertomalla ne luvulla 4,184.Tee kummallekin muunnokselle oma aliohjelma. (2 eri metodia)

            Console.WriteLine("Tämä ohjelma muuntaa kalorit jouleiksi ja päinvastoin.");
            Console.WriteLine("Jos haluat muuntaa joulet kaloreiksi, kirjoita \"j\"");
            Console.WriteLine("Jos haluat muuntaa kalorit jouleiksi, kirjoita \"k\"");

            char choice = char.Parse(Console.ReadLine());

            //  while (choice != 'e')



            if (choice == 'j')

            {
                Console.Write("Syötä joulet: ");
                double jouleInput = double.Parse(Console.ReadLine());
                Console.WriteLine($"Syöttämäsi joulet ovat {joulesToCalories(jouleInput)} kaloria");


            }

            else if (choice == 'k')

            {
                Console.Write("Syötä kalorit: ");
                double calInput = double.Parse(Console.ReadLine());
                Console.WriteLine($"Syöttämäsi kalorit ovat {caloriesToJoules(calInput)} joulea");


            }

            else  //no tää ei toimi oikeesti löl

            {
                Console.WriteLine("Jos haluat lopettaa, kirjoita \"e\"");

            }



            Console.ReadKey();



        }


        //k ==> j
        private static double caloriesToJoules(double calories)
        {

            return calories * 4.184d;

        }
        //j ==> k
        private static double joulesToCalories(double joules)

        {

            return joules * 0.2390d;

        }




    }
}
