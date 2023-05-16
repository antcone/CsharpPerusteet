using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wannabevandal
{
    class Program
    {
        static void Main(string[] args)
        {

            Sticker sticky1 = new Sticker("zombiehead", "Able", 2006, "green", false, 1.5);
            Sticker sticky2 = new Sticker("pincushion", "Vepa", 2012, "silver", true, 3);
            Sticker sticky3 = new Sticker("reading_owl", "Pöölau", 2021, "black", false, 1);
            Sticker sticky4 = new Sticker("able_seaman", "Able", 2011, "blue", false, 2.2);
            Sticker sticky5 = new Sticker("roach", "Tuma", 2011, "black", false, 2.2);
            // Sticker sticky5 = new Sticker();

            //no mä loin noita tarroja, mut haluan ne taulukkoon

            Sticker[] oldStickers = { sticky1, sticky2, sticky3, sticky4, sticky5 };


            //tää nyt ei tee muuta ku tulostaa tarrojen nimiä 
            for (int i = 0; i < oldStickers.Length; i++)

            {
                Console.WriteLine(oldStickers[i].StickerName);
            }


            //Tehhää lista tarroja varten
            List<Sticker> stickers = new List<Sticker>();

            //lisätään aiemman taulukon tavarat tänne listaan
            stickers.AddRange(oldStickers);

            bool userNotFinished = true;

            //Luodaan lisää tarroja
            while (userNotFinished)
            {

                Console.WriteLine("Anna tekijän nimi: (tai kirjoita 'end')");
                string artist = Console.ReadLine();
                if (artist.ToLower() == "end")
                {
                    userNotFinished = false;
                    continue;                   // liekö yhtään parempi näin kuin breakin kanssa, mut halusin et tää katkeaa tässä heti
                                                // ilman continueta se menee luupin loppuun ensin
                }

                Console.Write("Anna tarran nimi: ");
                string stickerName = Console.ReadLine();

                Console.Write("Anna tarran tekovuosi: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Anna tarran pääväri: ");
                string colour = Console.ReadLine();

                Console.Write("Onko tarra foili? K tai E ");
                char choice = char.Parse(Console.ReadLine());
                bool foil = choice == 'k' || choice == 'K';  // ? true : false; 

                Console.Write("Anna tarran hinta: ");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine();


                stickers.Add(new Sticker(stickerName, artist, year, colour, foil, price));


            }


            Console.WriteLine("Tulostan tarrojen tiedot valitsemassasi järjestyksessä");
            Console.WriteLine("Tarrat A-Ö : 1");
            Console.WriteLine("Taiteilijat A-Ö : 2");
            Console.WriteLine("Tekovuosi (uusin ensin) : 3");
            Console.WriteLine("Värit ryhmittäin : 4");


            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Sticker.SortByStickerName(stickers);
                    break;
                case 2:
                    Sticker.SortByArtistName(stickers);
                    break;
                case 3:
                    Sticker.SortByCreationYear(stickers);
                    break;
                case 4:
                    Sticker.SortByColour(stickers);  //koska tää on erilainen kuin nuo muut ja luuppaa jo metodin sisällä, tän ei pidä mennä tohon allaolevaan luuppiin
                                                     // tosin enää ei ookaan tuossa alla luuppia, koska laitoin sen tonne funktioksi. Mut kumminki, case 4 ohittaa
                                                     // nyt tuon StickerInfon kutsumisen
                                                     // return;   ei ollut hyvä vaihtoehto, koska se sulkee koko ohjelman
                    goto EndofProgram;  //mutta tämä vaikuttaa hauskalta, ja toimii. Tällä päästiin tuon StickerInfon ohi valittuun kohtaan ohjelmassa.  
            }



            StickerInfo(stickers);


        EndofProgram:  // tänne tullaan tuolta switchin case4:stä


            Console.ReadKey();
        }

        public static void StickerInfo(List<Sticker> stickers)
        {

            foreach (Sticker sticker in stickers)
            {
                //onpas tässä hirveän näppärä ternary, melkein tajunnanräjäyttävä. En tietty keksiny itte, vaan chatGPT ehdotti
                Console.WriteLine($"Tarran {sticker.StickerName} on tehnyt {sticker.ArtistName} vuonna {sticker.CreationYear}. Sen pääväri on {sticker.MainColour} ja {(sticker.Foil ? "se on" : "se ei ole")} foili.");
                Console.WriteLine($"Tarra on {sticker.HowOldIsIt()} vuotta vanha.");
                Console.WriteLine($"Tarran {sticker.StickerName} hinta on {sticker.Price} euroa.");
                Console.WriteLine();
            }


        }



    }
}
