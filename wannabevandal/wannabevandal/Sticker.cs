using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wannabevandal
{
    class Sticker
    {
        //properties

        public string StickerName { get; set; }
        public string ArtistName { get; set; }
        public int CreationYear { get; set; }
        public string MainColour { get; set; }
        public bool Foil { get; set; }
        public double Price { get; set; }
        

        //constructors


        public Sticker (string sticker, string artist, int year, string colour, bool foil, double price)
        {

            StickerName = sticker;
            ArtistName = artist;
            CreationYear = year;
            MainColour = colour;
            Foil = foil;
            Price = price;

        }

        public Sticker()
        {

            //chatGPT osas kertoa, että tarvitsen tämän
            Foil = false;
        }


        //methods

        public int HowOldIsIt()

        {
            return @DateTime.Now.Year - CreationYear;
        }


        //tää järjestää tarrat ikäjärjestykseen, uusin ensin
        public static void SortByCreationYear(List<Sticker> stickers)

        {
             stickers.Sort((a, b) => b.CreationYear.CompareTo(a.CreationYear));
        }


        //tää saanee tarrat aakkosjärjestykseen
        public static void SortByStickerName(List<Sticker> stickers)

        {
            stickers.Sort((a, b) => a.StickerName.CompareTo(b.StickerName));
        }

        //Tämä järjestää tarrat taiteilijan nimen perusteella aakkosjärjestykseen
        public static void SortByArtistName(List<Sticker> stickers)

        {
             stickers.Sort((a, b) => a.ArtistName.CompareTo(b.ArtistName));
        }


        //Jännä värilajittelu?? 
        public static void SortByColour(List<Sticker> stickers)
{
    var groups = stickers.GroupBy(s => s.MainColour);

    foreach (var group in groups)
    {
        Console.WriteLine($"Tarrat joiden pääväri on '{group.Key}':");

        foreach (var sticker in group)
        {
            Console.WriteLine($"- {sticker.StickerName} by {sticker.ArtistName}, {sticker.CreationYear}");
        }
    }
}


    }
}
