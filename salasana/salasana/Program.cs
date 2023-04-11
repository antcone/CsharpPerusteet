using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salasana
{
    class Program
    {
        static void Main(string[] args)
        {
            string chosenPassword = "herpderp555";
            bool passwordCorrect = false;



            while (passwordCorrect == false)
            {
                Console.Write("Syötä salasana: ");

                string passwordInput = Console.ReadLine();

                if (passwordInput == chosenPassword)


                {
                    Console.Write("Salasana oikein! ");
                 //   Console.WriteLine("Voitit pelin!");
                    passwordCorrect = true;

                }
                else
                {

                    Console.WriteLine("Salasana väärin!");

                }

            }
            Console.ReadKey();
        }
    }
}
