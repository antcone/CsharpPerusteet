using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj34Btunnilla
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Lue käyttäjältä sana talteen

            Console.Write("Syötä sana: ");
            string userInput = Console.ReadLine();

            //2. Luo taulukko sanan vokaaleille
            //Luodaan taulukon pituudeksi sama kuin sanan pituus, silloin ainakin riittää tila


            //datatyyppi[] taulukonNimi = new datatyyppi[taulukon pituus];
            char[] vocalsInWord = new char[userInput.Length];

            //List<datatyyppi> nimi = new List<datatyyppi>();
            List<char> vocalsUsingList = new List<char>();  // Lista.
                                                            //Lista on oletuksena tyhjä ja sen pituus/Count on 0
                                                            //vocalsUsingList[0] = 'n'; // Kaatuu, "System.ArgumentOutOfRangeException: 'Indeksi oli sallitun alueen ulkopuolella.
                                                            // Indeksi ei saa olla negatiivinen, ja sen on oltava kokoelmaa pienempi"
                                                            //tämä siksi koska lista on tyhjä. Sen elementtejä ei voida vielä käyttää.


            // 3. Käy sanan merkit läpi silmukassa

            //foreach olisi toinen vaihtoehto, mutta siinä on hanka saada indeksi, jota tarvitaan taulukossa

            //(silmukan) indeksi alkaa arvosta 0, koska (taulukon) indeksit alkavat nollasta
            //indeksimuuttujaa käytetään taulukossa
            //silmukan ehtona on taulukon pituus / indeksien lukumäärä. Kun iteroitava muuttuja i
            // on taulukon indeksien ulkopuolella, silmukka päättyy.
            // esim. test.Length == 4, jonka indeksit ovat 0, 1, 2, 3. Kun i saapuu arvoon 4, silmukka päättyy.
            // iterointi, i++


            for (int i = 0; i < userInput.Length; i++)

            {
                // kirjoitetaan merkit yksi kerrallaan, merkkiä voi käyttää syntaksilla
                // muuttujanNimi[indeksi]
                // Console.WriteLine(userInput[i]);

                // 4. Tallenna merkki taulukkoon, jos se on vokaali.
                //Cannot implicitly convert type 'char' to 'char[]' tulee, jos yrittää tehä tän allaolevasti
                //vocalsInWord = userInput[i];
                //joten siksipä tajuamme tehdä näin:

                // Lisätään merkin tallennus ehdon sisälle, joka tarkistaa, että merkki on vokaali
                // tutkitaan vain pieniä kirjaimia. Joskirjoittaa ison kirjaimen, ni ei toimi
                if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' ||
                    userInput[i] == 'o' || userInput[i] == 'u' || userInput[i] == 'y' ||
                    userInput[i] == 'ä' || userInput[i] == 'ö')

                {

                    vocalsInWord[i] = userInput[i];
                    vocalsUsingList.Add(userInput[i]); // Listaan lisätään elementti .Add()-metodilla

                }
            }


            // 5. Luo silmukka, jossa tulostetaan vokaalit taulukosta käyttäjälle
            // for olisi toinen vaihtoehto, mutta nyt ei välttämättä tarvita indeksiä

            foreach (char symbol in vocalsInWord)
            {
                //Ei tulosteta tyhjiä elementtejä
                // char taulukon oletusarvo on 0. Jos symbol on muutakuin 0 (symbol != 0)
                // siinä on jotain tallessa, ja se tulostetaan
                // Listassa ei tartte tehdä tällaista

                if (symbol != 0)
                {
                    Console.WriteLine(symbol);
                }
            }

            // Myös foreach toimisi
            // huom. listalla ei oo lengthiä vaan count!
            for (int i = 0; i < vocalsUsingList.Count; i++) // Lista
            {
                Console.WriteLine("Lista: " + vocalsUsingList[i]);

            }


            Console.ReadKey();

        }
    }
}
