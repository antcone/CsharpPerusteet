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

        public decimal CalculatePrice()
        {
            if (Toppings.Count > 3)
            {
                return BasePrice + Toppings.Count - 2;
            }

            else
                return BasePrice;


        }





    }
}
