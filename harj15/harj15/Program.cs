using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj15
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Arvaa kokonaisluku (0-1000)");
            int correctNumber = 899;

           // int inputNumber = int.Parse(Console.ReadLine());
            bool rightGuess = false;

            while (rightGuess == false)
            {   
                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber == correctNumber)
                {
                    rightGuess = true;
                    Console.WriteLine("Voitit pelin!");
                }
                else if (inputNumber < correctNumber)
                {
                    Console.WriteLine("Arvauksesi on liian pieni");
                }

                else
                {
                    Console.WriteLine("Arvauksesi on liian suuri");
                }


            }

            Console.ReadKey();

        }
    }
}
