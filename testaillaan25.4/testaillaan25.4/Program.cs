using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testaillaan25._4
{
    class Program
    {
        static void Main(string[] args)
        {

            Solution("testi", "ti");
            Console.ReadKey();
        }


        public static bool Solution(string str, string ending)
        {
            // TODO: complete
            // 25.4. tunnilla
            // Tutkitaan oikealta lähtien, ovatko merkit samoja string arvojen-välillä
            // 
            bool result = true; // oletuksena ending on str arvon pääte
            int j = ending.Length - 1;  //endingin vika indeksi

            for (int i = str.Length - 1; i > (str.Length - 1) - ending.Length; i--)
            {
                //   for(int j = ending.Length -1; j >= 0; j--)
                //  {
                if (str[i] != ending[j])
                {
                    // jos merkit eivät ole samoja, otetaan tieto talteen.
                    result = false;
                }
                j--;
                //  }

            }

            return result;
        }



    }
}
