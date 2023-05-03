using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttibeli
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lisätään koodi, joka generoi pakkaan kortit
            // Lisätään pakalle metodi, jolla nostetaan yksi kortti
            //  deck.Cards.Add(new Card(1, Card.Suites.Hearts));
            // Pakansekoitusmetodi

            // Tässä on pelin kaikki kortit
            Deck deck = new Deck();
            // Tässä on pelaajan käsi
            Deck player1Deck = new Deck();
            Deck player2Deck = new Deck();

            deck.GenerateCards();
            deck.Shuffle();  // jos tän poistaa, niin saa paremmin tasapelejä

            // Lisää sovellukseen toinen pelaaja
            // Nosta molemmille pelaajille kortit
            // Ilmoita kumpi voitti
            // Isompi arvo voittaa
            // Ässä == 1
            // Tasapelissä seuraavasti
            // Hearts > Diamonds > Clubs > Spades



            player1Deck.Cards.Add(deck.Draw());
            player2Deck.Cards.Add(deck.Draw());

            Console.WriteLine($"Pelaaja 1:  {player1Deck.Cards[0].Suite} {player1Deck.Cards[0].Value}");
            Console.WriteLine($"Pelaaja 2:  {player2Deck.Cards[0].Suite} {player2Deck.Cards[0].Value}");
            Console.WriteLine();

            if (player1Deck.Cards[0].Value != player2Deck.Cards[0].Value)
            {
                if (player1Deck.Cards[0].Value > player2Deck.Cards[0].Value)
                {
                    Console.WriteLine("Pelaaja 1 voitti!");
                }
                else
                {
                    Console.WriteLine("Pelaaja 2 voitti!");
                }

            }
            else  // jos sama arvo, verrataan maat. Pienin järjestysluku voittaa. Enumejakin voi kivasti vertailla tällee
            {
                if (player1Deck.Cards[0].Suite < player2Deck.Cards[0].Suite)
                {
                    Console.WriteLine("Pelaaja 1 voitti");
                }
                else
                {
                    Console.WriteLine("Pelaaja 2 voitti!");
                }
            }

            Console.ReadKey();
        }
    }
}
