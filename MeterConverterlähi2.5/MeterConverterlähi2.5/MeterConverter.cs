using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeterConverterlähi2._5
{
    class MeterConverter
    {

        public static double ToCentimeter(double meters)
        {
            return meters * 100;
        }

        public static double ToKilometer(double meters)
        {
            return meters / 1000;
        }

    }
}
