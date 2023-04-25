using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bensankulutus_luokkainkera
{
    class Trip
    {
        // Properties  
        // Data class, luokkaa voi käyttää pelkästään tietorakenteena, ilman toimintoja.

        public string Name { get; set; }

        public double Distance { get; set; }

        public double AverageConsumption { get; set; }

        public double FuelPrice { get; set; }

        private double  privateProperty { get; set; }  //Privaatti properties pienellä alkukirjaimella kuulemma, t. Microsoft

        // Constructors
        public Trip(string name, double distance, double averageConsumption, double fuelPrice)
        {
            Name = name;   //tallennetaan paremetri propertiin
            Distance = distance;
            AverageConsumption = averageConsumption;
            FuelPrice = fuelPrice;
        }

        // Methods

        //lasketaan matkan hinta mieluummin täällä ku mainissa
        //tää ei nyt sit oo pelkkä data class
        public double CalculateCost()
        {
            return Distance * AverageConsumption * FuelPrice / 100;
        }





    }
}
