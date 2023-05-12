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

            Sticker sticky1 = new Sticker("Able", "zombiehead", 2006, "green", false);
            Sticker sticky2 = new Sticker("Vepa", "pincushion", 2012, "silver", true);
            Sticker sticky3 = new Sticker("Pöölau", "reading_owl", 2021, "pink", false);
            Sticker sticky4 = new Sticker("Able", "able_seaman", 2011, "blue", false);
            Sticker sticky5 = new Sticker();


            Console.WriteLine($"Tarra on {sticky1.HowOldIsIt()} vuotta vanha");

            //Tehhää lista tarroja varten
            List<Sticker> stickers = new List<Sticker>();


            //Luodaan niitä tarroja
            while(true)
            {


            Console.WriteLine("Anna tekijän nimi: (tai kirjoita 'end')" );
            string artist = Console.ReadLine();
                if (artist.ToLower() == "end")
                {
                    break;
                }

                Console.WriteLine("Anna tarran nimi: ");
            string stickerName = Console.ReadLine();

            Console.WriteLine("Anna tarran tekovuosi: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna tarran pääväri: ");
            string colour  = Console.ReadLine();

            Console.WriteLine("Onko tarra foili? K tai E ");
            char choice = char.Parse(Console.ReadLine());
            bool foil = choice == 'k' || choice == 'K' ? true : false;


                stickers.Add(new Sticker(artist, stickerName, year, colour, foil));


            }


            foreach (Sticker sticker in stickers)
            {
                //onpas tässä hirveän näppärä ternary, melkein tajunnanräjäyttävä. En tietty keksiny itte, vaan chatGPT ehdotti
                Console.WriteLine($"Tarran {sticker.StickerName} on tehnyt {sticker.ArtistName} vuonna {sticker.CreationYear}. Sen pääväri on {sticker.MainColour} ja {(sticker.Foil ? "se on" : "se ei ole")} foili.");
                Console.WriteLine($"Tarra on {sticker.HowOldIsIt()} vuotta vanha.");
            }





            Console.ReadKey();
        }
    }
}
