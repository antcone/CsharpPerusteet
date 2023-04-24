using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lähi24._4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Luokka / Class
             * 
             * Olio-ohjelmoinnin pohjimmainen idea on jaka sovellus pieniin kokonaisuuksiin (Luokkiin/olioihin)
             * Ideana on jakaa laaja ongelma pieniin osiin
             * Sovelluksissa on pääsääntöisesti kahta asiaa: 1. Data (Property) 2. Toiminnallisuus (Method)
             * Luokkien idea on yhdistää oleellinen data ja toiminnallisuus yhteen pakettiin.
             *
             * 
             * TODO: luokan lisääminen omaan tiedostoon
             * 

            Luokan luomisen sijainti, samalle tasolle muiden luokkien kanssa.
            Tässä tiedostossa "Program" -luokan kanssa samalle tasolle.

            Luodaan luokasta objekteja */

            Person personA = new Person();
            personA.Age = 30;
            personA.Name = "Juho";
            Console.WriteLine($"Henkilön A nimi on: {personA.Name} ja ikä on: {personA.Age}");

            Person personB = new Person(25, "Matti", 1.8, new List<Pet>());


            Person personC = new Person(35, "Jesse", 2.0, new List<Pet>());




            Console.ReadLine();

        }

    } //Class "Program" päättyy


    //class - avainsana
    //Test - oma luokan nimi, ISOLLA alkukirjaimella (toimii pienelläkin, mutta ei ole suotavaa käyttää)
    //(kuulemma esim. private-metodin alkukirjain pitäis olla pieni, public-metodin iso. Joku konventio tääkin sitte. Tai sitten ei oo oikeesti, who knows)


    public class Person // Luokkien idea on mallintaa jotakin todellista asiaa. Tiettyyn pisteeseen saakka. Minkälaista asiaa ihmisessä on tallessa?

    {       // 2a. Constructor
            //Erityismetodi, jolla tallennetaan objektiin oletusarvoja.
            //[Näkyvyys]
            //[nimi], jonka täytyy olla täysin sama kuin luokan nimi!

        public Person() //Constructoria voi olla monta eri versiota
        {

        }


        public Person(int age, string name, double length, List<Pet> pets)
        {
            Age = age;  //parametri age tallennetaan propertyyn Age
            Name = name;
            Length = length;
            Pets = pets;
        }




        // 2b. Property
        //kirjoita prop ja sen jälkeen sarkain kaksi kertaa
        //Propertyn syntaksi: [Näkyvyys] [datatyyppi] [nimi] [gat ja set]
        //[get ja set] get määrittää, kuinka arvo luetaan ja set määrittää, kuink arvo tallennetaan
        //Ei laiteta luokkia toistensa sisään tässä vaiheessa, vaikka se voikin olla mahdollista

        public int Age { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Location CurrentLocation { get; set; }
        public List<Pet> Pets { get; set; }



        //2c. Metodi / Method
        // Toiminnallisuus

        //Metodi palauttaa matkan pituuden uuden ja vanhan sijainnin välillä. Mut me ei välttämättä tarvita sitä, vois olla vaikka void
        public int Walk(Location newLocation)
        {
            int result = CurrentLocation.CoordinateX - newLocation.CoordinateX;
            CurrentLocation = newLocation; //Päivitetään uusi sijainti
            return result;
        }


    }

    public class Pet

    {
        public string Name { get; set; }

        public int Age { get; set; }
    }


    public class Location
    {
        public int CoordinateX { get; set; }
    }



}
