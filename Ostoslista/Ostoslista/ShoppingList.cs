using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostoslista
{

    //Voidaan luoda ostoslistoja eri kaupoille.
    //Tuote lisätessä listaan "haetaan" tuotteen hinta
    class ShoppingList
    {

        // Properties

        public string ShopName { get; set; }

        private List<Product> Products { get; set; }  //laitetaan private, jotta kukaan ei pääse muokkaamaan propertya suoraan
                                                      //kaikki toiminnot metodien kautta

        public decimal Sum { get; set; }

        //Constructors
        public ShoppingList(string shopName)
        {
            ShopName = shopName;
            Sum = 0; // tämä on tosin jo oletus, joten ei välttämättä tarpeen
            Products = new List<Product>();
        }

        // Methods
        public void AddProduct(string productName)
        {
            Product temp = new Product(productName);
            Products.Add(temp);
            Sum += temp.Price;  // Pyöristä 5 senttiin...tai ei pyöristetäkään, koska digitaalista rahnua
        }


    }
}
