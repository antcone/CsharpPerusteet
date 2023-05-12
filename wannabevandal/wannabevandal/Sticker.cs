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
        

        //constructors


        public Sticker (string sticker, string artist, int year, string colour, bool foil)
        {

            StickerName = sticker;
            ArtistName = artist;
            CreationYear = year;
            MainColour = colour;
            Foil = foil;

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





    }
}
