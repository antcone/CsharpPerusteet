using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj34C
{
    class Program
    {
        static void Main(string[] args)
        {
            // 34C C# String: Poista kirjaimia alusta ja lopusta
            //Kirjoita ohjelma, joka lukee käyttäjältä merkkijonon ja kokonaisluvun, joka kertoo montako merkkiä merkkijonon alusta ja lopusta poistetaan.

            //Ohjelma tulostaa typistetyn merkkijonon näytölle.
            //Ohjelma tulostaa virheilmoituksen, jos poistettavien merkkien lukumäärä on pienempi tai yhtä suuri kuin nolla tai jos kahdella kerrottu lukumäärä
            //on yhtä suuri tai suurempi kuin merkkijonon pituus. Jos syötteet ovat esimerkiksi "abc" ja 1, tulostaa ohjelma näytölle merkkijonon "b",
            //koska alkuperäisen merkkijonon ensimmäinen ja viimeinen merkki poistetaan.
            //https://moodle.sakky.fi/mod/assign/view.php?id=1159656


            string input = " ";
            string[] splitInput = new string[1]; //placeholder taulukko
            bool inputHasErrors = true;

            while (inputHasErrors == true)

            {
            Console.Write("Syötä sana ja poistettavien merkkien määrä (\"Omena 1\"): ");
            
            input = Console.ReadLine();

            splitInput = input.Split(' ');
                //tällä taulukolla on indeksti 0 ja 1

                //muokataan "inputHasErrors" -totuusmuuttujan arvo false, jos käyttäjän syöte on OK
                //Tällöin silmukka päättyy


                //splitInput[1] on käyttäjän antama luku, splitInput[0] on käyttäjän antama sana, molemmat tekstiä ennen parsetusta
                //0 == vähintään poistettavien merkkien määrä
                //2 == lasketaan yhteensä poistettavien merkkien määrä kertomalla poistettavat merkit kahdella
                //     alusta ja lopusta == kertaa 2
                if (int.Parse(splitInput[1]) > 0 && int.Parse(splitInput[1])*2 < splitInput[0].Length)
                {
                    inputHasErrors = false;
                }


            }
            //Tällä taulukolla on indeksit 0 ja 1, joissa 0 on annettu sana ja 1 annettu kokonaisluku

            // TODO: error checking and place ReadLine inside a loop until passes error checking
            // [ luku > 0 ] JA [ luku *2 < sana.Length ]

            // Vaihtoehto 1
            // Otetaan käyttäjän sanasta Substring 
            // Substring vaatii aloitusindeksin ja montako merkkiä otetaan talteen aloituskohdasta lähtien.

            //              0123456  <- string arvon indeksit
            // Esimerkiksi "testaus" 2  
            // Tarvittavat arvot Substring-metodiin alla
            // Nämä indeksit ovat itse string merkkijonon indeksejä
            // Aloitusindeksi: 2
            // Tallennettavien merkkien määrä: 3 => sanan pituus - alun poisto - lopun poisto = merkkien määrä
            //                                      splitInput[0].Length - poistettavat merkit *2 = merkkien määrä

            // UUSI TERMI: parametri, on metodin sulkujen sisälle syötetyt arvot
            //             overload, metodi voi ottaa vastaan eri märän parametrejä. Overload ilmaisee montako vaihtoehtoa on.
            //             Hiiri metodin päällä, ctrl+K sitten ctrl+P voi käydä läpi kaikki eri overload vaihtoehdot.
            //             Ideaalimaailmassa, mutta ei se ainakaan tänään toimi
            string result1 = splitInput[0].Substring(int.Parse(splitInput[1]), splitInput[0].Length - (int.Parse(splitInput[1]) * 2));
            Console.WriteLine(result1);
            //Vaihtoehto 1




            // Vaihtoehto 2
            // Tehdään silmukka, jossa tallennetaan merkkejä yksi kerrallaan
            // "testaus 2" Aloitetaan silmukka kolmannesta indeksistä ja jatketaan viimeiseen kopioitavaan indeksiin
            // => "sta"

            string result2 = ""; //Tähän lisätään merkkejä yksi kerrallaan

            //silmukka alkaa ensimmäisen tallennettavan merkin indeksistä ja loppuu viimeiseen tallennettavaan indeksiin.
            for (int i = int.Parse(splitInput[1]); i < splitInput[0].Length - int.Parse(splitInput[1]); i++)  //käyttäjän syöttämä luku integerinä; i < sanan pituus - käyttäjän syöttämä luku; iteraatio
            {
                result2 += splitInput[0][i];  //kopioidaan merkki käyttäjän sanan tietystä indeksistä
                // splitInput[0] viittaa käyttäjän sanaan eli => "testaus"[i]
            }


            Console.WriteLine(result2);
            //Vaihtoehto 2

            Console.ReadKey();

        }
    }
}
