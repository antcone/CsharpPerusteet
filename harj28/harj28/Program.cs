using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj28
{
    class Program
    {
        static void Main(string[] args)
        {

            int chosenNumber, a, oddOrEven;  //nimetään muuttujat. ChosenNumber on käyttäjän antama luku, a on laskuri, oddOrEven on pariton-parillinen -valintaa varten
            bool keepAsking = true; //tämä on while-luuppia varten

            while (keepAsking)  // tän takia ohjelma kyselee lukuja loputtomiin. Tästä voi hankkiutua eroon halutessaan. 
            {
                a = 0;          
                Console.WriteLine();
                Console.WriteLine("Tämä ohjelma tulostaa parilliset tai parittomat luvut nollasta valitsemaasi lukuun asti.");
                Console.Write("Anna luku: ");
                chosenNumber = int.Parse(Console.ReadLine());
                Console.Write("Tulostetaanko parilliset (1) vai parittomat (2)?  ");  //pyydetään käyttäjää valitsemaan kumpia lukuja halutaan.
                                                                                      //tässä parilliset valitaan kirjoittamalla "1" ja parittomat vastaavasti "2"
                oddOrEven = int.Parse(Console.ReadLine());
                Console.WriteLine();


                if (oddOrEven == 1)  //kun käyttäjä valitsee parilliset luvut, päädytään tänne
                {
                    Console.WriteLine($"Parilliset luvut {a} - {chosenNumber}: ");  //kerrotaan, miltä väliltä numerot tulostetaan
                    Console.WriteLine();

                    while (a <= chosenNumber) //laskurin ollessa pienempi kuin annettu luku
                    {

                    

                        if (a % 2 == 0)   //etsitään parilliset luvut
                        {

                            Console.WriteLine(a);

                        }
                        a++;  //kasvatetaan laskuria yhdellä

                    }
                    


                }

                else if (oddOrEven == 2)  //Muuten tämä blokki on kuin yllä, mutta parittomille luvuille
                {
                    Console.WriteLine($"Parittomat luvut {a} - {chosenNumber}: ");
                    Console.WriteLine();

                    while (a <= chosenNumber)

                    {
                        if (a % 2 == 1)  //etsitään ne parittomat jakojäännöksen avulla. Kakkosella jakaessa jakojäännös ei voi muuta olla kuin 1 tai 0.
                        {


                            Console.WriteLine(a);

                        }
                        a++;

                    }
                    

                }
                else
                {
                    Console.WriteLine("Haluatko lopettaa?");  //askarrellaan tällainen ruma lopetusehto. Jos pariton-parillinen valinnassa
                                                              //käyttäjä antaa jonkin muun luvun kuin "1" tai "2", päädytään tänne
                    Console.WriteLine("Y  N");                // ohjelmassa on sekä suomea että englantia, sekään ei oo kaunista. Mut olkoon.

                    string choice = Console.ReadLine();

                    if (choice == "y" || choice == "Y")   //sekä pieni että iso y kelpaavat. Varmaan vois käyttää jotain char-hommeliakin
                                                          //käyttäjä voi kirjoittaa vastaukseksi mitä vaan, ainoastaan y tai Y lopettaa ohjelman
                                                          //mut tässä leikisti annetaan vaihtoehdoksi tuo n

                    {
                        keepAsking = false;  //tällä loppuu kysely, ja käytännössä ohjelmakin
                    }


                }





            }

            Console.ReadKey();
        }
    }
}
