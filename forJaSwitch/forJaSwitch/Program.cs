using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forJaSwitch
{
    class Program
    {
        static void Main(string[] args)

            //for ja switch harjoitus
        {
            double initialValue = 12d; //nimetään ja alustetaan muuttuja initialValue
            int revolutions = 4;  //toistojen määrä for-silmukkaa varten

            for (int i = 1; i <= revolutions; i++)  //silmukka pyörii neljästi

            {
                switch (i)  //switchataan i:n arvoa 1-4. Eli tehään noi kaikki vaihtoehdot vuorotellen
                {
                    case 1:
                        //lisätään i lukuun initialValue 
                        //12+1 = 13
                        initialValue += i;
                        
                        break;
                    case 2:
                        //kerrotaan initialValue luvulla i
                        //13*2 = 26
                        initialValue *=  i;
                       
                        break;
                    case 3:
                        //jaetaan initialValue luvulla i
                        //26/3 = 8.6666666
                        initialValue /= i;  
                        //yllä voisi lukea initialValue = initialValue /i; mutta 
                        //tää VS ohjaa kirjoittamaan lyhyemmin, ja onhan se toki kaunista
                       
                        break;
                    case 4:
                        //vähennetään i luvusta initialValue
                        //8.6666666-4 = 4.66666666
                        //koska tämä on viimeinen case ja kierros, tulostetaan initialValuen arvo tässä
                        //laskutoimituksen jälkeen toki vasta
                        initialValue -= i;
                        Console.WriteLine(initialValue);
                        break;

                }

            }
            //voi sen halutessaan tulostaa täälläkin
            //Console.WriteLine(initialValue);
            Console.ReadKey();


        }
    }
}
