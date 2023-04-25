using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alatjatilavuudet
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Pinta-alat ja tilavuudet (Yhdessä päivä 10)
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159681
            // Lasketaan suorakulmion ("neliön") ja kolmion ala sekä piiri

            Square squareOne = new Square(5, 10);
            Console.WriteLine($"Area of square one is {squareOne.Area()}");  // pinta-ala
            Console.WriteLine($"Circumference of square one is {squareOne.Circumference()}"); //piiri

            Square squareTwo = new Square(1, 2);

            Console.WriteLine();

            Triangle triangleOne = new Triangle(2, 5);
            Console.WriteLine($"Area of triangle one is {triangleOne.Area()}");  // pinta-ala
            Console.WriteLine($"Perimeter of triangle one is {triangleOne.Perimeter()}");  // pinta-ala

            Console.WriteLine();

            Console.ReadKey();
        }


    }


    public class Square  // oikeesti tän nimi pitäis olla Rectangle. Neliö on vain suorakulmion erikoistapaus.
                         // Jos haluttais laskea pelkästään neliön alaa ja piiriä,
                         // se olis vielä helpompaa kuin mitä tässä on tehty.
    {
        //Properties
        public double Width { get; set; }

        public double Heigth { get; set; }

        //Constructors

        public Square(double width, double heigth)
        {
            Width = width;
            Heigth = heigth;
        }
        //Methods

        public double Area() //Huom, ei tarvitse parametrejä. Voi olla parametrejä tarvittaessa
        {
            return Width * Heigth;
        }

        public double Circumference()
        {
            return (Width * 2) + (Heigth * 2);
        }


    }
}
