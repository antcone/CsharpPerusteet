using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)


        {
            // C# for ja switch
            // https://moodle.sakky.fi/mod/assign/view.php?id=1163232

            #region

            double initialValue = 12d;

            //Luodaan for-silmukka, joka tapahtuu 4 kertaa
            //1 - 2 - 3 - 4

            for (int i = 1; i<5; i++)

            {

                switch(i) //sulkujen sisällä tutkittava arvo
                {
                    case 1:
                        // koodi
                        initialValue += i;
                        break; //päättää switch rakenteen suorituksen
                    case 2:
                        initialValue = initialValue * i;
                        break;
                    case 3:
                        initialValue /= i;
                        break;
                    case 4:
                        initialValue = initialValue - i;
                        break;


                }

            }
            Console.WriteLine($"Lopputulos: {initialValue}");


            #endregion

            Console.ReadKey();
        }
    }
}
