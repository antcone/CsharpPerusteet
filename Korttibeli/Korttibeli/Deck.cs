using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttibeli
{
    class Deck
    {

        //Properties


       // Lista korttiobjekteja
       public List<Card> Cards = new List<Card>();

        // Constructors


       // Methods


        // Generoidaan Deck-luokan listaan yksi kappale jokaista korttia.
        public void GenerateCards()
        {
            // Korttien arvot korttipakassa
            const int numberOfValues = 13;

            for(int i = 1; i <= numberOfValues; i++)
            {
                foreach (Card.Suites suite in Enum.GetValues(typeof(Card.Suites)))  //kysy vaikka chatGPT:ltä,, jollei muute lähe
                {
                    // Lisätään uusi korttiobjekti tämän objektin kortit-listaan
                    Cards.Add(new Card(i, suite));
                }
            }


        }

        // Nostetaan alin kortti

        // metodi palauttaa kortti-objektin
        public Card Draw()
        {
            // tallennetaan viittaus muuttujaan
            Card tempCard = Cards[0];  //Kaatuu, jos lista on tyhjä
            //deletoidaan viittaus korttiin Cards-listalta
            Cards.RemoveAt(0); 

            return tempCard; 
        }

        //Sekoitetaan pakan kortit
        public void Shuffle()
        {
            //Fisher-Yeates algoritmi, tämän tarjosi chatGPT
            Random random = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);  // random.Next(10) palauttaisi lukuja 0-9, muttei itse parametriä 10. Siksi meillä n+1
                Card temp = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = temp;
            }

        }

    }
}
