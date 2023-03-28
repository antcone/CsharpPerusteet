using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lahi28._3
{
    class Program
    {
        static void Main(string[] args)
        {


            // Ohjausrakenne - Control structure
            // 1. if-rakenne

            // if(ehto - condition) //lopputulos true / false
            // { 
            //if condition == true
            //suoritetaan if-blokin koodi

            // } < end of if code block
            // jos condition == false
            // hypätään koodiblokin yli

            Console.WriteLine("Ennen if");
            if(50 > 10) //

            {
             Console.WriteLine("sisällä if");
            }
            Console.WriteLine("Jälkeen if");

            Console.WriteLine();
            Console.WriteLine("Press Any Key to exit");
            Console.ReadKey();

            // 2. if - else
            //joko suoritetaan if code block
            //tai else code block

            Console.WriteLine();
            Console.WriteLine("ennen if");
            if ("moi" != "terve")
            {
                Console.WriteLine("inside if");
            }
            else
            { 
                Console.WriteLine("inside else");
            }
            Console.WriteLine("after if-else");


            Console.WriteLine();
            Console.WriteLine("press any key to exit");
            Console.ReadKey();

            Console.WriteLine();

            //3. if - else if - else
            // rakenteessa voi olla myös muita vertailuja
            // ainoastaan yksi code block suoritetaan
            // vaikka useampi olisi totta

            if (6.5 >= 5.5)  //stringejä ei voi vertailla näillä suurempi tai pienempi kuin operaattoreilla, yllätyyys
            {
                Console.WriteLine("inside if");
            }
            else if (10 <= 20)
            {
                Console.WriteLine("inside else if");
            }
            else
            {
                Console.WriteLine("inside else");
            }

            Console.WriteLine();
            Console.WriteLine("paina nappulaa jos huvittaa");
            Console.ReadKey();

            // Vertailuoperaattorit - comparison operators
            // vertailujen lopputulos on totuusarvo - boolean
            // true / false

            // ==   samat arvot
            // !=   eri arvot
            // <    vasen pienempi kuin oikea
            // >    vasen isompi kuin oikea
            // <=   vasen pienempi tai yhtä suuri kuin oikea
            // >=   vasen isompi tai yhtä suuri kuin oikea

            // Loogiset operaattorit - logical operators
            // Voidaan yhdistää useampi vertailuoperaatio

            // &&   molemmat totta -and-
            // age >= ageLimit && length == targetHeigth

            // ||   toinen totta -or- ctrl + alt + <
            // age >= ageLimit || length == targetHeigth

            // !    kääntää totuusarvon
            // bool accountDeleted = true;
            // if(!accountDeleted)
            // {
            // Jos tiliä ei ole poistettu, voidaan käyttää
            // }

            // if sulkujen sisällä pitää olla true
            // jos vertaillaan arvoa, jonka halutaan olevan false
            // ! ennen muuttujaa


            // Silmukat - Loops
            // while(condition)
            //  {
            // Execute done
            // as long as condition == true
            //  }

            //  huom pikakommentointihauskuus!
            //  kommentointi ctrl + k sitten ctrl + c
            //  poisto ctrl + k sitten ctrl + u
            //while (true)
            //{
            //    Console.Write("moi");
            //}

            Console.WriteLine();
            string input =""; //tyhjä string, ei toimi jollei oo jokin arvo ees
            //while (input != "exit" || input != "EXIT") tää ei ainakaan toimi

            while (input != "exit")
            {
                Console.WriteLine("Choose action: ");
                input = Console.ReadLine();
                Console.WriteLine($"Executing action {input}");

            }







        }
    }
}
