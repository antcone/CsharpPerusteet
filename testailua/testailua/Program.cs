using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testailua
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number to add: ");


                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number to add: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int num3 = num1 + num2;

                string num11 = Convert.ToString(num1);
                string num22 = Convert.ToString(num2);

                Console.WriteLine(" " + num1 + " + " + num2 + " = " + num3);


                Console.WriteLine("Do You want to add more numbers? Y / N");

                string YesOrNo = Console.ReadLine();

                if (YesOrNo == "N")
                {
                    break;
                }
            }
        }
    }
}
