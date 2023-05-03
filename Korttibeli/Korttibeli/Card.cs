using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttibeli
{
    class Card
    {
        // Properties
        public enum Suites // Voi tallentaa vakioarvoja
        {
            Hearts,    // 0
            Diamonds,  // 1
            Clubs,     // 2
            Spades     // 3
        }

        public int Value { get; set; } // 1 - 13
        public Suites Suite { get; set; }  // "Hertta", "Pata", "Risti", "Ruutu"

        // Constructors
        public Card(int value, Suites suite)
        {
            Value = value;
            Suite = suite;
        }

        // Methods



    }
}
