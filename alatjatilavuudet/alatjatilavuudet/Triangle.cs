﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alatjatilavuudet
{
    class Triangle
    {
        //Properties
        public double Heigth { get; set; }

        public double Base { get; set; }

        //Constructors
        public Triangle(double heigth, double baseParameter)
        {
            Heigth = heigth;
            Base = baseParameter;
        }

        //Methods
        // Ei tarvitse static, koska tätä käytetään luokan objektista.
        // Esim. Triangle test = new Triangle(2, 5); - Luodaan objekti luokasta nimeltä "test"
        // Console.WriteLine(test.Area());   - käytetään objektin metodia
        public double Area()
        {
            double result = 0;

            result = Base * Heigth / 2;

            return result;
        }
        
        public double Perimeter()  //Math.Exp() laittaa matemaattisen vakion e annettuun potenssiin, 
                                    // eli ei tarvita tässä sitä vaan Math.Pow(luku, potenssi)
        {
            // hypotenuse = √(base^2 + heigth^2)

            double result = 0;

            result = Heigth + Base + Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Heigth, 2));

            return result;
        }



    }
}
