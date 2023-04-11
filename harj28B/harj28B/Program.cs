using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj28B
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tulostan numerot 1-5.");

            int startNumber;
            int endNumber = 5;

            for (startNumber = 1; startNumber <= endNumber; startNumber++)

            {
                Console.WriteLine(startNumber);

            }

            startNumber = 1;  // startNumber olis äskeisen silmukan jälkeen 6, joten alustetaan se taas ykköseksi tässä

            Console.WriteLine("Tulostan numerot 5-1.");

            for (endNumber = 5; endNumber >= startNumber; endNumber--)

            {
                Console.WriteLine(endNumber);
            }



            Console.WriteLine("Tulostan luvut antamaltasi väliltä.");
            Console.Write("Anna eka luku: ");
            int firstInput = int.Parse(Console.ReadLine());  //siis ehkä tähän jokin apumuuttuja mieluummin

            //  Console.WriteLine(startNumber);
            ;
            Console.Write("Anna toka luku: ");
            int lastInput = int.Parse(Console.ReadLine());
            //  Console.WriteLine(endNumber);

            if (firstInput < lastInput)

            {
                endNumber = lastInput;
                Console.WriteLine($"Tulostan luvut {firstInput} - {lastInput} nousevassa järjestyksessä");

                for (startNumber = firstInput; startNumber <= endNumber; startNumber++)

                {
                    Console.WriteLine(startNumber);

                }
            }

            else if (firstInput > lastInput)

            {
                endNumber = lastInput;
                Console.WriteLine($"Tulostan luvut {lastInput} - {firstInput} laskevassa järjestyksessä");

                for (startNumber = firstInput; startNumber >= endNumber; startNumber--)

                {
                    Console.WriteLine(startNumber);
                }

            }

            else
            {
                //Console.WriteLine("Luvut ovat samat.");  kumpi näistä sit hyödyllisempi on
                Console.WriteLine(firstInput);
            }



            Console.ReadKey();
        }
    }
}
