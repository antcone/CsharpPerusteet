using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koe
{
    class Product
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }



        public Product(int id, string name, decimal price)

        {
            Id = id;
            Name = name;
            Price = price;
        }


        public decimal CalculateDiscountedPrice(decimal DiscountPercentage)
        {
            decimal finalPrice = Price * (100 - DiscountPercentage) / 100;

            return finalPrice;
        }

    }
}
