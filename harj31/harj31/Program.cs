using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj31
{
    class Program
    {
        static void Main(string[] args)
        {

            //31 Lukujen summa ja keskiarvo

            Console.Write("Anna lukujen määrä: ");
            int numberAmount = int.Parse(Console.ReadLine());       // pyydetään käyttäjältä lukujen määrä ja tallennetaan muuttujaan
            double sum = 0;                                        //summamuuttuja, tähän lasketaan annettujen lukujen summa. Tehdään siitä double
                                                                   // jotta saadaan keskiarvoksikin double. Kunhan jompikumpi, sum tai numberAmount, on double.
                                                                   // Emmehän halua menettää desimaaleja.

            for (int i = 1; i <= numberAmount; i++)                 //tehdään kyselylooppi, for on hyvä koska tiedämme kierrosmäärän
            {
                Console.Write($"Anna {i}. luku: ");                 //pyydetään käyttäjältä lukuja, kerrotaan käyttäjäystävällisesti monesko luku on meneillään
                int number = int.Parse(Console.ReadLine());
                sum += number;                                   //lisätään summamuuttujaan käyttäjän antaman luku joka kierroksella
                // sum = sum + int.Parse(Console.ReadLine());
            }

            double average = sum / numberAmount;  //tehdään huvikseen keskiarvolle oma muuttuja, ettei tartte laskea tossa WriteLinen sisällä
                                                  //ja voishan se olla muutenkin näppärä, jos sitä tarttis jossain muualla

            Console.WriteLine($"Lukujen summa on {sum} ja keskiarvo {average}."); //kerrotaan käyttäjälle halutut tiedot

            Console.ReadKey();
        }
    }
}
