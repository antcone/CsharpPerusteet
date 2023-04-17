using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj37C
{
    class Program
    {
        static void Main(string[] args)
        {

            //37 C# String: Lämpötilan seuranta
            // Tee ohjelma, johon syötetään päivän lämpötilat.Lämpötilat mitataan kello 6, 12, 18 ja 24.
            // Kun arvot on syötetty ohjelma laskee päivän suurimman, pienimmän ja keskilämpötilan.

            //https://moodle.sakky.fi/mod/assign/view.php?id=1159662

            int measurings = 4;
            double[] temperaturesArray = new double[measurings];

            List<double> temperaturesList = new List<double>();

            double input = 0;

            for (int i=0; i<measurings; i++)
            {

                Console.WriteLine($"Anna {i+1}. mittaustulos:");

                input = double.Parse(Console.ReadLine());
                temperaturesArray[i] = input;
                temperaturesList.Add(input);




            }

            //Taulukon suurin, pienin ja keskiarvo metodeilla
            Console.WriteLine("Taulukko:");
            Console.WriteLine($"Pienin arvo: {temperaturesArray.Min()}\n suurin arvo: {temperaturesArray.Max()}\n keskiarvo: {temperaturesArray.Average()}");


            //Taulukon suurin ja pienin iteraatiolla (käytännössä sama, mitä metodit tekevät)

            //etsitään taulukon suurin luku, laitetaan taulukon eka luku suurimmaksi ja verrataan sitä muihin lukuihin
            //kun löytyy suurempi, siitä tulee uusi max
            //samalla tavalla haetaan pienin luku
            double max = temperaturesArray[0];
            double min = temperaturesArray[0];
            double sum = 0; 

            for(int i=0; i<temperaturesArray.Length; i++ )

            {
                if (temperaturesArray[i]>max)  //etsitään suurin luku

                
                    max = temperaturesArray[i];
                

                if (temperaturesArray[i] < min)  //etsitään pienin luku

                    min = temperaturesArray[i];


                sum += temperaturesArray[i];  //lasketaan summa keskiarvoa varten


            }


            //keskiarvo saadaan tästä
            double average = sum / temperaturesArray.Length;



            //Listan suurin, pienin ja keskimäärä metodeilla 

            Console.WriteLine("Lista:");
            Console.WriteLine($"Keskiarvo: {temperaturesList.Average()}");
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(average);



            (double doubleTemp, int intTime)[] timesWithTemps = new (double, int)[temperaturesArray.Length];

            int time = 0;
            for (int i = 0; i < temperaturesArray.Length; i++)

                
            {
                Console.WriteLine($"Anna {i+1}. mittaustulos:");

                input = double.Parse(Console.ReadLine());
                time = time + 6;  //haha lol 
                timesWithTemps[i] = (input, time) ;

                Console.WriteLine(timesWithTemps[i]);
            }



            Console.Write(timesWithTemps.Max());

            



            Console.ReadKey();

        }
    }
}
