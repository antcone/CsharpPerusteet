using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._4.lähi
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //string text = "Hello";

            ////aloitetaan arvosta 0, koska indeksit alkavat nollasta
            //for (int i = 0; i < text.Length; i++)

            //    //tiettyyn indeksiin päästään käsiksi hakasuluilla, joiden ssällä on indeksin arvo
            //    Console.WriteLine(text[i]);


            //string hello = "         Hello World  ";
            //Console.WriteLine(hello);
            //Console.WriteLine(hello.Trim());

            /*
             * 33 C# String: Merkkien tulostus
            Tee ohjelma joko tulostaa sanan alusta tai lopusta halutun määrän merkkejä. Käyttäjä valitse tulostetaanko merkit sanan alusta vai lopusta.

            Pyydetään sana ja tulostussuunta yhdellä input:lla.
            
             https://moodle.sakky.fi/mod/assign/view.php?id=1159653 */

            //Esimerkki käyttäjän syötteestä; "Lattia A" "Seinä L"

            //merkki " voidaan näyttää käyttäjälle kenoviivalla ennen " merkkiä   ctrl + alt + ?  

            Console.Write("Syötä sana ja tulostussuunta (\"Lattia A\"): ");
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(' '); 
            
            //inputSplit[0] == "terve"
            //inputSplit[1] == "L"

            //Tarvitaan valintarakenne, jolla tutkitaan tulostuksen suuntaa
            //ehtorakenne kääntää string

            if (inputSplit[1] == "A") // tulostetaan alusta loppuun
            {
                //tää on nyt tarpeeton
            }
            else if (inputSplit[1] == "L")  //tulostetaan lopusta alkuun
            {
                char[] chars = inputSplit[0].ToCharArray();  
                Array.Reverse(chars);
                string test = new string(chars);
                inputSplit[0] = test;

            }

            foreach (char jokinNimi in inputSplit[0])
            {
                Console.WriteLine(jokinNimi);
            }























            Console.ReadKey();

        }
    }
}
