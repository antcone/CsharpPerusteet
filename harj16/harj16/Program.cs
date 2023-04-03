using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj16
{
    class Program
    {
        static void Main(string[] args)
        {

            ////if-else rakenne

            //Console.WriteLine("Ohjelma kertoo, mihin vuodenaikaan kuukausi kuuluu.");
            //Console.WriteLine("Kuukaudet ovat numeroitu 1-12 tammikuusta alkaen.");
            //Console.Write("Anna kuukauden numero: ");
            //Console.WriteLine();

            //int selectedMonth = int.Parse(Console.ReadLine());


            //if (selectedMonth < 1 || selectedMonth > 12)  //suljetaan pois mahdottomat numerot. Ei pelkästään huvikseen, vaan jotta talvikuukausien käsittely olis helpompi

            //{
            //    Console.WriteLine($"{selectedMonth} ei ole kuukauden numero.");
            //}

            //else if (selectedMonth == 9 || selectedMonth == 10)  //syyskuukaudet 9 ja 10

            //{
            //    Console.WriteLine("Kuukausi on syksyä.");
            //}

            //else if (selectedMonth == 6 || selectedMonth == 7 || selectedMonth == 8)  //kesäkuukaudet 6,7,8

            //{
            //    Console.WriteLine("Kuukausi on kesää.");
            //}

            //else if (selectedMonth == 4 || selectedMonth == 5)  //kevätkuukaudet 4 ja 5

            //{
            //    Console.WriteLine("Kuukausi on kevättä.");
            //}

            //else
            //{
            //    Console.WriteLine("Kuukausi on talvea.");  //talvikuukausia ovat 11,12,1,2,3. 
            //                                               //Ne ovat vähän tylsästi erillään toisistaan, mutta koska edellä on jo käsitelty kaikki muut kuukaudet
            //                                               //niin tälleenhän niistä päästään

            //}



            ////if, string

            //Console.WriteLine("Ohjelma kertoo, mihin vuodenaikaan kuukausi kuuluu.");
            //Console.Write("Anna kuukausi tekstinä (esim. 'joulukuu'):  ");
            //string monthIF = Console.ReadLine();

            ////muokataan teksti pieniksi kirjaimiksi
            //monthIF = monthIF.ToLower();

            //if (monthIF == "tammikuu" || monthIF == "helmikuu" || monthIF == "maaliskuu" || monthIF == "marraskuu" || monthIF == "joulukuu")
            //{
            //    Console.WriteLine("Kuuluu talveen.");
            //}
            //else if (monthIF == "huhtikuu" || monthIF == "toukokuu")
            //{
            //    Console.WriteLine("Kuuluu kevääseen.");
            //}
            //else if (monthIF == "kesäkuu" || monthIF == "heinäkuu")
            //{
            //    Console.WriteLine("Kuuluu kesään.");
            //}
            //else if (monthIF == "syyskuu" || monthIF == "lokakuu")
            //{
            //    Console.WriteLine("Kuuluu syksyyn.");
            //}
            //else
            //{
            //    Console.WriteLine("Syöttämääsi kuukautta ei löytynyt.");
            //}

            //Console.ReadKey();



            //Console.ReadKey();


            ////switch-versio
            //Console.WriteLine("Ohjelma kertoo, mihin vuodenaikaan kuukausi kuuluu.");
            //Console.WriteLine("Kuukaudet ovat numeroitu 1-12 tammikuusta alkaen.");
            //Console.Write("Anna kuukauden numero: ");
            //Console.WriteLine();

            //int selectedMonth = int.Parse(Console.ReadLine());

            //switch (selectedMonth)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 11:
            //    case 12:

            //        Console.WriteLine("Kuukausi on talvea.");
            //        break;

            //    case 4:
            //    case 5:
            //        Console.WriteLine("Kuukausi on kevättä.");
            //        break;

            //    //C# 7 versiossa voidaan ilmaista myös tietty numeroalue (range)

            //    case int xyz when (xyz >= 6 && xyz <= 8): // oltava JA, jotta saadaan vain numerot 6,7,8
            //        Console.WriteLine("Kesäkuukausi, jee");
            //        break;

            //    case int xyz when xyz >= 9 && xyz <= 10:
            //        Console.WriteLine("Syyskuukausi");
            //            break;
            //    default:
            //        Console.WriteLine("Virheellinen numero");
            //        break;




            //}



            //ternary-versio

            Console.WriteLine("Ohjelma kertoo, mihin vuodenaikaan kuukausi kuuluu.");
            Console.WriteLine("Kuukaudet ovat numeroitu 1-12 tammikuusta alkaen.");
            Console.Write("Syötä kuukausi numerona: ");
            int monthTernary = int.Parse(Console.ReadLine());

            string message = "";

            //ternary vertailu, hieno ketjutus
            //falsen tilalle uusi vertailu

            message = monthTernary == 11 || monthTernary == 12 || monthTernary >= 1 && monthTernary <= 3 ? "Talvi" :
                    monthTernary >= 4 && monthTernary <= 5 ? "Kevät" :
                    monthTernary >= 6 && monthTernary <= 8 ? "Kesä" :
                    monthTernary >= 9 && monthTernary <= 10 ? "Syksy" :
                    "Virheellinen arvo";  //jos mikään muu ei ollu totta, valituksi tulee tää viimeisen vertailun false


            Console.WriteLine(message);

            Console.ReadKey();



        }
    }
}
