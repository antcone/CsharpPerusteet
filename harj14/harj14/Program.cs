using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj14
{
    class Program
    {
        static void Main(string[] args)
        {

            //ohjelma, joka kysyy luvun käyttäjältä ja kertoo onko luku parillinen vai pariton

            int input;  //alustetaan muuttuja input
           
            while (true) // silmukka, jotta arvoja kysellään loputtomiin
                         //tässä ohjelmassa ei ole lopetusehtoa
                         


            {
                Console.Write("Anna luku: ");  
                input = int.Parse(Console.ReadLine());  //kysytään käyttäjältä luku 
                

                if (input % 2 == 0)  //modulo-operaattori, jakojäännös.
                                     //Jaetaan käyttäjän antama luku luvulla kaksi. Kun jakojäännös on 0, luku on parillinen

                {
                    Console.WriteLine($"Luku {input} on parillinen");  //no toistetaan nyt huvikseen tuo input myös
                    
                }

                else 
                {
                    Console.WriteLine($"Luku {input} on pariton");  //jos luku ei ole parillinen, on se pariton

                }

                
                Console.WriteLine();
                //Console.ReadKey();


            }



           


        }
    }
}
