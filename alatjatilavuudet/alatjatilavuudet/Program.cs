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


            Square squareOne = new Square(5, 10);
            Console.WriteLine($"Area of square one is {squareOne.Area()}");
            Console.WriteLine();


            Console.ReadKey();
        }


    }


    public class Square
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
