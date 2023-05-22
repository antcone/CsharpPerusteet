using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituskoe_pitsa
{
    class Pizza
    {
        public List<Topping> Toppings { get; set; }
        public decimal BasePrice { get; set; }
        public int freeToppings { get; set; }


        public Pizza(List<Topping> toppings, decimal basePrice)
        {
            Toppings = toppings;
            BasePrice = basePrice;
        }

        public Pizza()
        {
            Toppings = new List<Topping>();
            BasePrice = 15;

        }

        public decimal CalculatePrice()
          
        {
            int freeToppings = 3;
            decimal finalPrice = BasePrice;

            if (Toppings.Count == 0)
            {
                finalPrice= BasePrice - BasePrice;
            }

            else if (Toppings.Count > freeToppings)
            {
                finalPrice = BasePrice + Toppings.Count - freeToppings;
            }

            else
            {
                
            }

            return finalPrice;

        }





    }
}
