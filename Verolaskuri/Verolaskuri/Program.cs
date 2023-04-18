using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verolaskuri
{
    class Program
    {
        static void Main(string[] args)
        {

            //C# Funktiot: Verolaskuri (Yhdessä päivä 9)
            //Tee uusi ohjelma, joka kysyy käyttäjältä palkan määrään(brutto) ja veroprosenttia.
            //Lisää metodi, joka ottaa parametreinä palkan(brutto) ja veroprosentin.
            //            Metodi palauttaa palkan(nettona).
            //            Esim: 1000 ja 10 => 900

            //Extra: Metodi palauttaa nettopalkan lisäksi veron määrän.


            Console.WriteLine("Syötä bruttopalkka: ");
            decimal grossPay = decimal.Parse(Console.ReadLine());


            Console.WriteLine("Syötä veroprosentti: ");
            decimal taxPercentage = decimal.Parse(Console.ReadLine());

            (decimal, decimal) netAndTax = taxCalculator(grossPay, taxPercentage);
            Console.WriteLine($"Nettopalkka on: {netAndTax.Item1} \r\nMaksettu vero on: {netAndTax.Item2}");


            Console.ReadKey();

        }

        //Koska käsitellään rahaa, olis hyvä ottaa käyttöön tarkin desimaalimuoto eli decimal
        //Metodi palauttaa tuple datarakenteen, joka on pari arvoja

        private static (decimal, decimal) taxCalculator(decimal grossPay, decimal taxPercentage)

        {

            (decimal, decimal) result = (0, 0);


            result.Item1 = (grossPay / 100) * (100 - taxPercentage);
            result.Item2 = grossPay - (grossPay / 100) * (100 - taxPercentage);


            return result;

        }



        //tää oli versio ennen tuplea

        //private static decimal taxCalculator(decimal grossPay, decimal taxPercentage)

        //{

        //    decimal result = 0;
        //    // decimal netPay = grossPay * taxPercentage;
        //    // decimal taxAmount = grossPay - netPay;


        //    result = (grossPay / 100) * (100 - taxPercentage);


        //    return result;

        //}




    }
}
