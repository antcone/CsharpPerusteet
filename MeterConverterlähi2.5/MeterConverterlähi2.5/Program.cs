using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeterConverterlähi2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159680
            // 
            // 

            Console.Write("Syötä metrit: ");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine($"{meters}m sentteinä on: {MeterConverter.ToCentimeter(meters)}");
            Console.WriteLine($"{meters}m kilometreinä on: {MeterConverter.ToKilometer(meters)}");

            Console.ReadKey();

        }
    }
}
